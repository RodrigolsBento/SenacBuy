using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Infrastructure.Data;

namespace SenacBuy.Infrastructure.Repositories;

/// <summary>
/// Implementação concreta do repositório de Pedido.
/// Note o uso de Include() para carregar as entidades relacionadas (Eager Loading).
/// Isso evita o problema N+1 de consultas ao banco de dados.
/// </summary>
public class PedidoRepository : IPedidoRepository
{
    private readonly SenacBuyDbContext _context;

    public PedidoRepository(SenacBuyDbContext context)
    {
        _context = context;
    }

    public async Task<Pedido?> ObterPorIdAsync(int id)
        => await _context.Pedidos
            .Include(p => p.Cliente)          // Carrega o cliente junto
            .Include(p => p.Itens)            // Carrega os itens junto
                .ThenInclude(i => i.Produto)  // Carrega o produto de cada item
            .FirstOrDefaultAsync(p => p.Id == id);

    public async Task<IEnumerable<Pedido>> ListarTodosAsync()
        => await _context.Pedidos
            .Include(p => p.Cliente)
            .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
            .ToListAsync();

    public async Task<IEnumerable<Pedido>> ListarPorClienteAsync(int clienteId)
        => await _context.Pedidos
            .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
            .Where(p => p.ClienteId == clienteId)
            .ToListAsync();

    public async Task AdicionarAsync(Pedido pedido)
    {
        await _context.Pedidos.AddAsync(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Pedido pedido)
    {
        _context.Pedidos.Update(pedido);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var pedido = await ObterPorIdAsync(id);
        if (pedido != null)
        {
            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
        }
    }
}

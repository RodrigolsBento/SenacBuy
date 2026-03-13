using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Infrastructure.Data;

namespace SenacBuy.Infrastructure.Repositories;

/// <summary>
/// Implementação concreta do repositório de Cliente.
/// </summary>
public class ClienteRepository : IClienteRepository
{
    private readonly SenacBuyDbContext _context;

    public ClienteRepository(SenacBuyDbContext context)
    {
        _context = context;
    }

    public async Task<Cliente?> ObterPorIdAsync(int id)
        => await _context.Clientes.FindAsync(id);

    public async Task<Cliente?> ObterPorCPFAsync(string cpf)
        => await _context.Clientes
            .FirstOrDefaultAsync(c => c.CPF == cpf);

    public async Task<IEnumerable<Cliente>> ListarTodosAsync()
        => await _context.Clientes.ToListAsync();

    public async Task AdicionarAsync(Cliente cliente)
    {
        await _context.Clientes.AddAsync(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var cliente = await ObterPorIdAsync(id);
        if (cliente != null)
        {
            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
        }
    }
}

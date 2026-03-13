using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Infrastructure.Data;

namespace SenacBuy.Infrastructure.Repositories;

/// <summary>
/// Implementação concreta do repositório de Produto.
/// </summary>
public class ProdutoRepository : IProdutoRepository
{
    private readonly SenacBuyDbContext _context;

    public ProdutoRepository(SenacBuyDbContext context)
    {
        _context = context;
    }

    public async Task<Produto?> ObterPorIdAsync(int id)
        => await _context.Produtos.FindAsync(id);

    public async Task<IEnumerable<Produto>> ListarTodosAsync()
        => await _context.Produtos.ToListAsync();

    public async Task AdicionarAsync(Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Produto produto)
    {
        _context.Produtos.Update(produto);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var produto = await ObterPorIdAsync(id);
        if (produto != null)
        {
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}

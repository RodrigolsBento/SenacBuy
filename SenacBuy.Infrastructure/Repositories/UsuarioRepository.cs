using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Infrastructure.Data;

namespace SenacBuy.Infrastructure.Repositories;

/// <summary>
/// Implementação concreta do repositório de Usuário.
/// Esta classe é o único lugar da aplicação que conhece o DbContext
/// para operações de usuário.
/// </summary>
public class UsuarioRepository : IUsuarioRepository
{
    private readonly SenacBuyDbContext _context;

    public UsuarioRepository(SenacBuyDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario?> ObterPorIdAsync(int id)
        => await _context.Usuarios.FindAsync(id);

    public async Task<Usuario?> ObterPorEmailAsync(string email)
        => await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());

    public async Task<IEnumerable<Usuario>> ListarTodosAsync()
        => await _context.Usuarios.ToListAsync();

    public async Task AdicionarAsync(Usuario usuario)
    {
        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task AtualizarAsync(Usuario usuario)
    {
        _context.Usuarios.Update(usuario);
        await _context.SaveChangesAsync();
    }

    public async Task RemoverAsync(int id)
    {
        var usuario = await ObterPorIdAsync(id);
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
    }
}

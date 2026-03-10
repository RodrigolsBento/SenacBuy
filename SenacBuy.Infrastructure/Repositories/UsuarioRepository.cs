using Microsoft.EntityFrameworkCore;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Infrastructure.Data;

namespace SenacBuy.Infrastructure.Repositories;

public class UsuarioRepository: IUsuarioRepository
{

    //objeto do contexto, fazer com que todos os metodos acesem o contexto 
    private readonly SenacBuyDbContext _context;

    //injeção no usuário repositorio, injeção do contexto para acessar o banco 
    public UsuarioRepository (SenacBuyDbContext context)
    {
        _context = context;
    }

    //await faz requisição em segundo plano
    public async Task<Usuario> ObterPorIdAsync(int id) => await _context.Usuarios.FindAsync(id);
    public async Task<Usuario> ObterPorEmailAsync (string email) => await _context.Usuarios.FirstOrDefaultAsync(usuario => usuario.Email.ToLower() == email.ToLower());//com normalização de email para evitar problemas de caixa alta e caixa baixa

    public async Task<IEnumerable<Usuario>> ListarTodosAsync() => await _context.Usuarios.ToListAsync();

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
        var usuario = await ObterPorIdAsync(id);//infere o retorno da operação
        if (usuario != null)
        {
            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
        }
    }





}

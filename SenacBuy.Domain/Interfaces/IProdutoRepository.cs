using SenacBuy.Domain.Entities;

namespace SenacBuy.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato de acesso a dados para a entidade Produto.
/// </summary>
public interface IProdutoRepository
{
    Task<Produto?> ObterPorIdAsync(int id);
    Task<IEnumerable<Produto>> ListarTodosAsync();
    Task AdicionarAsync(Produto produto);
    Task AtualizarAsync(Produto produto);
    Task RemoverAsync(int id);
}

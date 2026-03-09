using SenacBuy.Domain.Entities;

namespace SenacBuy.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato de acesso a dados para a entidade Cliente.
/// </summary>
public interface IClienteRepository
{
    Task<Cliente?> ObterPorIdAsync(int id);
    Task<Cliente?> ObterPorCPFAsync(string cpf);
    Task<IEnumerable<Cliente>> ListarTodosAsync();
    Task AdicionarAsync(Cliente cliente);
    Task AtualizarAsync(Cliente cliente);
    Task RemoverAsync(int id);
}

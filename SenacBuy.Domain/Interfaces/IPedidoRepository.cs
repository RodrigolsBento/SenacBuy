using SenacBuy.Domain.Entities;

namespace SenacBuy.Domain.Interfaces;

/// <summary>
/// Interface que define o contrato de acesso a dados para a entidade Pedido.
/// </summary>
public interface IPedidoRepository
{
    Task<Pedido?> ObterPorIdAsync(int id);
    Task<IEnumerable<Pedido>> ListarTodosAsync();
    Task<IEnumerable<Pedido>> ListarPorClienteAsync(int clienteId);
    Task AdicionarAsync(Pedido pedido);
    Task AtualizarAsync(Pedido pedido);
    Task RemoverAsync(int id);
}

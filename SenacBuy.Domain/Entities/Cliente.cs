namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa um cliente da loja.
/// Clientes realizam pedidos.
/// </summary>
public class Cliente
{
    public int Id { get; set; }

    /// <summary>Nome completo do cliente</summary>
    public string Nome { get; set; } = string.Empty;

    /// <summary>
    /// CPF do cliente (apenas dígitos ou formatado).
    /// Regra de negócio: não pode haver dois clientes com o mesmo CPF.
    /// </summary>
    public string CPF { get; set; } = string.Empty;

    /// <summary>
    /// Coleção de pedidos associados a este cliente.
    /// Relacionamento: 1 Cliente possui N Pedidos.
    /// </summary>
    public ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();
}

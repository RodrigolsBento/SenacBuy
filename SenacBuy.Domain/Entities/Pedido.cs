namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa um pedido de compra realizado por um cliente.
/// Um pedido agrupa vários itens e calcula o total automaticamente.
/// </summary>
public class Pedido
{
    public int Id { get; set; }

    /// <summary>Chave estrangeira para o cliente que fez o pedido</summary>
    public int ClienteId { get; set; }

    /// <summary>Data e hora em que o pedido foi realizado</summary>
    public DateTime DataPedido { get; set; } = DateTime.Now;

    /// <summary>
    /// Valor total do pedido, calculado com base nos itens.
    /// Regra: Total = Somatório de (Quantidade * PrecoUnitario) de cada item.
    /// </summary>
    public decimal Total { get; set; }

    /// <summary>
    /// Status atual do pedido.
    /// Valores possíveis: Pendente, Finalizado, Cancelado.
    /// </summary>
    public string Status { get; set; } = "Pendente";

    // Propriedades de navegação (EF Core)
    /// <summary>Referência ao cliente (objeto completo)</summary>
    public Cliente? Cliente { get; set; }

    /// <summary>
    /// Coleção de itens deste pedido.
    /// Relacionamento: 1 Pedido possui N ItensPedido.
    /// Regra: deve conter pelo menos 1 item.
    /// </summary>
    public ICollection<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

    /// <summary>
    /// Recalcula o Total com base nos itens atuais.
    /// Útil após adicionar/remover itens.
    /// </summary>
    public void RecalcularTotal()
    {
        Total = Itens.Sum(i => i.Quantidade * i.PrecoUnitario);
    }
}

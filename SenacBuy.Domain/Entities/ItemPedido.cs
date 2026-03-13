namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa um item dentro de um pedido.
/// Cada item associa um produto a um pedido, com quantidade e preço no momento da venda.
/// </summary>
public class ItemPedido
{
    public int Id { get; set; }

    /// <summary>Chave estrangeira para o pedido</summary>
    public int PedidoId { get; set; }

    /// <summary>Chave estrangeira para o produto</summary>
    public int ProdutoId { get; set; }

    /// <summary>Quantidade deste produto no pedido</summary>
    public int Quantidade { get; set; }

    /// <summary>
    /// Preço do produto no momento da venda.
    /// Importante: armazenamos o preço atual pois o preço do produto pode mudar no futuro.
    /// </summary>
    public decimal PrecoUnitario { get; set; }

    // Propriedades de navegação (EF Core)
    public Pedido? Pedido { get; set; }
    public Produto? Produto { get; set; }

    /// <summary>
    /// Calcula o subtotal deste item (Quantidade * PrecoUnitario)
    /// </summary>
    public decimal Subtotal => Quantidade * PrecoUnitario;
}

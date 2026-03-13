namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa um produto disponível para venda.
/// </summary>
public class Produto
{
    public int Id { get; set; }

    /// <summary>Nome/descrição do produto</summary>
    public string Nome { get; set; } = string.Empty;

    /// <summary>
    /// Preço unitário do produto.
    /// Regra de negócio: preço não pode ser negativo.
    /// </summary>
    public decimal Preco { get; set; }

    /// <summary>
    /// Coleção de itens de pedido que referenciam este produto.
    /// Relacionamento: 1 Produto aparece em N ItensPedido.
    /// </summary>
    public ICollection<ItemPedido> ItensPedido { get; set; } = new List<ItemPedido>();

    /// <summary>
    /// Caminho relativo para a foto do produto.
    /// Opcional, salvo dentro de uploads/produtos.
    /// </summary>
    public string? FotoProduto { get; set; }

    /// <summary>
    /// Chave estrangeira para a categoria do produto.
    /// Opcional — produto pode existir sem categoria.
    /// </summary>
    public int? CategoriaId { get; set; }

    /// <summary>
    /// Referência à categoria (objeto completo).
    /// Relacionamento: N Produtos → 1 Categoria.
    /// </summary>
    public Categoria? Categoria { get; set; }
}

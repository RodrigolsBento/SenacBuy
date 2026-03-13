namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa uma categoria de produto.
/// Exemplo: Eletrônicos, Periféricos, Monitores.
/// </summary>
public class Categoria
{
    public int Id { get; set; }

    /// <summary>Nome da categoria (obrigatório, máx. 100 caracteres)</summary>
    public string Nome { get; set; } = string.Empty;

    /// <summary>
    /// Coleção de produtos pertencentes a esta categoria.
    /// Relacionamento: 1 Categoria → N Produtos.
    /// </summary>
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}

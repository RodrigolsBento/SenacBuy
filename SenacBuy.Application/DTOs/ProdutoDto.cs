namespace SenacBuy.Application.DTOs;

/// <summary>DTOs de Produto para comunicação entre camadas</summary>

public class ProdutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string? FotoProduto { get; set; }
}

public class CriarProdutoDto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string? FotoProduto { get; set; }
}

public class AtualizarProdutoDto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public string? FotoProduto { get; set; }
}

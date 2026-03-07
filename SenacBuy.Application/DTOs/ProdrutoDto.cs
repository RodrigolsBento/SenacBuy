namespace SenacBuy.Application.DTOs;

public class ProdrutoDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;

    public decimal Preco { get; set; }


}

public class CriarProdutoDto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}

public class AtualizarProdutoDto
{
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; }
}

namespace SenacBuy.Application.DTOs;

public  class PedidoDto
{

    public int Id { get; set; }

    public int ClienteId { get; set; }
    public string NomeCliente { get; set; } = string.Empty;//campo personalizando, não necessáriamente espelhando no banco 
    
    public DateTime DataPedido { get; set; }

    public decimal  Total { get; set; }

    public List <ItemPedidoDto> Itens { get; set; } = new();


}

public class ItemPedidoDto
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; } = string.Empty;//campo personalizando, não necessáriamente espelhando no banco 
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal => Quantidade * PrecoUnitario;
}

public class CriarPedidoDto
{
    public int ClienteId { get; set; }
    public List<CriarItemPedidoDto> Itens { get; set; } = new();
}

public class CriarItemPedidoDto
{
    public int ProdutoId { get; set; }
    public int Quantidade { get; set; }
    
}


namespace SenacBuy.Application.DTOs;

/// <summary>DTOs de Pedido para comunicação entre camadas</summary>

public class PedidoDto
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public string NomeCliente { get; set; } = string.Empty;
    public DateTime DataPedido { get; set; }
    public decimal           Total       { get; set; }
    public string            Status      { get; set; } = "Pendente";
    public List<ItemPedidoDto> Itens     { get; set; } = new();
}

public class ItemPedidoDto
{
    public int Id { get; set; }
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; } = string.Empty;
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

public class AtualizarPedidoDto
{
    public int                      ClienteId { get; set; }
    public string                   Status    { get; set; } = "Pendente";
    public List<CriarItemPedidoDto> Itens     { get; set; } = new();
}

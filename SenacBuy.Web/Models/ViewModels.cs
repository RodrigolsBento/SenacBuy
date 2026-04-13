namespace SenacBuy.Web.Models;

// ─────────────────────────────────────────────────────────────────────────────
// ViewModels utilizados pelos Controllers e Views da aplicação MVC SenacBuy.
// Cada ViewModel espelha os DTOs da API sem depender dos projetos de domínio.
// ─────────────────────────────────────────────────────────────────────────────

public class ClienteViewModel
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF  { get; set; } = string.Empty;
}

public class CategoriaViewModel
{
    public int    Id   { get; set; }
    public string Nome { get; set; } = string.Empty;
}

public class ProdutoViewModel
{
    public int     Id           { get; set; }
    public string  Nome         { get; set; } = string.Empty;
    public decimal Preco        { get; set; }
    public int?    CategoriaId  { get; set; }
    public string? CategoriaNome { get; set; }
    public string? FotoProduto  { get; set; }
}

public class ItemPedidoViewModel
{
    public int     ProdutoId     { get; set; }
    public string  NomeProduto   { get; set; } = string.Empty;
    public int     Quantidade    { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal      => Quantidade * PrecoUnitario;
}

public class PedidoViewModel
{
    public int    Id          { get; set; }
    public int    ClienteId   { get; set; }
    public string NomeCliente { get; set; } = string.Empty;
    public DateTime DataPedido { get; set; }
    public decimal  Total      { get; set; }
    public string   Status     { get; set; } = "Pendente";
    public List<ItemPedidoViewModel> Itens { get; set; } = new();
}

public class UsuarioViewModel
{
    public int     Id         { get; set; }
    public string  Nome       { get; set; } = string.Empty;
    public string  Email      { get; set; } = string.Empty;
    public string  Senha      { get; set; } = string.Empty;
    public string? FotoPerfil { get; set; }
}

public class DashboardViewModel
{
    public decimal TotalVendas        { get; set; }
    public int     TotalClientes      { get; set; }
    public int     TotalProdutos      { get; set; }
    public int     TotalPedidos       { get; set; }
    public int     PedidosPendentes   { get; set; }
    public int     PedidosConcluidos  { get; set; }
    public int     PedidosCancelados  { get; set; }
    public List<PedidosMesViewModel> PedidosPorMes { get; set; } = new();
}

public class PedidosMesViewModel
{
    public int Ano   { get; set; }
    public int Mes   { get; set; }
    public int Total { get; set; }
}

public class ErrorViewModel
{
    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

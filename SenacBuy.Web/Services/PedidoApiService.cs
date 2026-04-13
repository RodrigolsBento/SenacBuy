using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Pedidos.
/// </summary>
public class PedidoApiService
{
    private readonly HttpClient _http;

    public PedidoApiService(IHttpClientFactory factory)
        => _http = factory.CreateClient("SenacBuyAPI");

    public async Task<List<PedidoViewModel>> ListarAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<PedidoViewModel>>("/api/pedido") ?? new();
        }
        catch { return new(); }
    }

    public async Task<PedidoViewModel?> ObterPorIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<PedidoViewModel>($"/api/pedido/{id}");
        }
        catch { return null; }
    }

    public async Task<bool> CriarAsync(PedidoViewModel vm)
    {
        var dto = new
        {
            vm.ClienteId,
            itens = vm.Itens.Select(i => new { i.ProdutoId, i.Quantidade }).ToList()
        };
        var resp = await _http.PostAsJsonAsync("/api/pedido", dto);
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> AtualizarAsync(PedidoViewModel vm)
    {
        var dto = new
        {
            vm.ClienteId,
            vm.Status,
            itens = vm.Itens.Select(i => new { i.ProdutoId, i.Quantidade }).ToList()
        };
        var resp = await _http.PutAsJsonAsync($"/api/pedido/{vm.Id}", dto);
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var resp = await _http.DeleteAsync($"/api/pedido/{id}");
        return resp.IsSuccessStatusCode;
    }
}

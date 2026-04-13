using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Clientes.
/// </summary>
public class ClienteApiService
{
    private readonly HttpClient _http;

    public ClienteApiService(IHttpClientFactory factory)
        => _http = factory.CreateClient("SenacBuyAPI");

    public async Task<List<ClienteViewModel>> ListarAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<ClienteViewModel>>("/api/cliente") ?? new();
        }
        catch { return new(); }
    }

    public async Task<ClienteViewModel?> ObterPorIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<ClienteViewModel>($"/api/cliente/{id}");
        }
        catch { return null; }
    }

    public async Task<bool> CriarAsync(ClienteViewModel vm)
    {
        var resp = await _http.PostAsJsonAsync("/api/cliente", new { vm.Nome, vm.CPF });
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> AtualizarAsync(ClienteViewModel vm)
    {
        var resp = await _http.PutAsJsonAsync($"/api/cliente/{vm.Id}", new { vm.Id, vm.Nome, vm.CPF });
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var resp = await _http.DeleteAsync($"/api/cliente/{id}");
        return resp.IsSuccessStatusCode;
    }
}

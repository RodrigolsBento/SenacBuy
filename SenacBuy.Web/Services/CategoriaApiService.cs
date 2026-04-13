using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Categorias.
/// </summary>
public class CategoriaApiService
{
    private readonly HttpClient _http;

    public CategoriaApiService(IHttpClientFactory factory)
        => _http = factory.CreateClient("SenacBuyAPI");

    public async Task<List<CategoriaViewModel>> ListarAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<CategoriaViewModel>>("/api/categorias") ?? new();
        }
        catch { return new(); }
    }
}

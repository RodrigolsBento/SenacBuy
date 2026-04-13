using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Dashboard.
/// </summary>
public class DashboardApiService
{
    private readonly HttpClient _http;

    public DashboardApiService(IHttpClientFactory factory)
        => _http = factory.CreateClient("SenacBuyAPI");

    public async Task<DashboardViewModel> ObterAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<DashboardViewModel>("/api/dashboard") ?? new();
        }
        catch { return new(); }
    }
}

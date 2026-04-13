using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Produtos.
/// </summary>
public class ProdutoApiService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl;

    public ProdutoApiService(IHttpClientFactory factory, IConfiguration config)
    {
        _http = factory.CreateClient("SenacBuyAPI");
        _baseUrl = config["ApiBaseUrl"] ?? "http://localhost:5000";
    }

    public async Task<List<ProdutoViewModel>> ListarAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<ProdutoViewModel>>("/api/produto") ?? new();
        }
        catch { return new(); }
    }

    public async Task<ProdutoViewModel?> ObterPorIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<ProdutoViewModel>($"/api/produto/{id}");
        }
        catch { return null; }
    }

    public async Task<bool> CriarAsync(ProdutoViewModel vm)
    {
        var resp = await _http.PostAsJsonAsync("/api/produto", new
        {
            vm.Nome,
            vm.Preco,
            vm.CategoriaId,
            vm.FotoProduto
        });
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> AtualizarAsync(ProdutoViewModel vm)
    {
        var resp = await _http.PutAsJsonAsync($"/api/produto/{vm.Id}", new
        {
            vm.Id,
            vm.Nome,
            vm.Preco,
            vm.CategoriaId,
            vm.FotoProduto
        });
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var resp = await _http.DeleteAsync($"/api/produto/{id}");
        return resp.IsSuccessStatusCode;
    }

    /// <summary>
    /// Faz upload da foto do produto via multipart/form-data.
    /// Retorna o caminho relativo salvo, ou null em caso de erro.
    /// </summary>
    public async Task<string?> UploadFotoAsync(int produtoId, IFormFile foto)
    {
        using var form = new MultipartFormDataContent();
        using var stream = foto.OpenReadStream();
        form.Add(new StreamContent(stream), "file", foto.FileName);

        var resp = await _http.PostAsync($"/api/upload/produto/{produtoId}", form);
        if (!resp.IsSuccessStatusCode) return null;

        var result = await resp.Content.ReadFromJsonAsync<UploadResultDto>();
        return result?.CaminhoRelativo;
    }

    private record UploadResultDto(string CaminhoRelativo);
}

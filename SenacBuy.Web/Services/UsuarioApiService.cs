using System.Net.Http.Json;
using SenacBuy.Web.Models;

namespace SenacBuy.Web.Services;

/// <summary>
/// Serviço para comunicação com a API de Usuários.
/// </summary>
public class UsuarioApiService
{
    private readonly HttpClient _http;

    public UsuarioApiService(IHttpClientFactory factory)
        => _http = factory.CreateClient("SenacBuyAPI");

    public async Task<List<UsuarioViewModel>> ListarAsync()
    {
        try
        {
            return await _http.GetFromJsonAsync<List<UsuarioViewModel>>("/api/usuario") ?? new();
        }
        catch { return new(); }
    }

    public async Task<UsuarioViewModel?> ObterPorIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<UsuarioViewModel>($"/api/usuario/{id}");
        }
        catch { return null; }
    }

    public async Task<bool> CriarAsync(UsuarioViewModel vm)
    {
        var dto = new { vm.Nome, vm.Email, Senha = vm.Senha, vm.FotoPerfil };
        var resp = await _http.PostAsJsonAsync("/api/usuario", dto);
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> AtualizarAsync(UsuarioViewModel vm)
    {
        var dto = new { vm.Id, vm.Nome, vm.Email, vm.FotoPerfil };
        var resp = await _http.PutAsJsonAsync($"/api/usuario/{vm.Id}", dto);
        return resp.IsSuccessStatusCode;
    }

    public async Task<bool> RemoverAsync(int id)
    {
        var resp = await _http.DeleteAsync($"/api/usuario/{id}");
        return resp.IsSuccessStatusCode;
    }

    /// <summary>
    /// Faz upload da foto de perfil do usuário via multipart/form-data.
    /// Retorna o caminho relativo salvo, ou null em caso de erro.
    /// </summary>
    public async Task<string?> UploadFotoAsync(int usuarioId, IFormFile foto)
    {
        using var form = new MultipartFormDataContent();
        using var stream = foto.OpenReadStream();
        form.Add(new StreamContent(stream), "file", foto.FileName);

        var resp = await _http.PostAsync($"/api/upload/usuario/{usuarioId}", form);
        if (!resp.IsSuccessStatusCode) return null;

        var result = await resp.Content.ReadFromJsonAsync<UploadResultDto>();
        return result?.CaminhoRelativo;
    }

    private record UploadResultDto(string CaminhoRelativo);
}

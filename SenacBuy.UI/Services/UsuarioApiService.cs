//using SenacBuy.Application.DTOs;
using SenacBuy.UI.Services.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace SenacBuy.UI.Services;

public class UsuarioApiService //comunicação entre API e o forms, tmb funciona para o MVC
{
    private readonly HttpClient _http = ApiClientService.Cliente;//responsável por fazer tudo funcionar 

    //Criar metodos para fazer requizições 
    public async Task<LoginResponseDto?> LoginAsync(string email, string senha)
    {

        try
        {
            //payloading
            var payload = new LoginDto { Email = email, Senha = senha };
            var response = await _http.PostAsJsonAsync("api/Usuario/Login", payload);//envia a requisição para a API, passando o payload
            
            var resultado = await response.Content.ReadFromJsonAsync<LoginResponseDto>();//lê a resposta da API e desserializa para o tipo LoginResponseDto    
            return resultado;//retorna o resultado para quem chamou o método
        }
        catch (HttpRequestException ex)
        {

            MessageBox.Show($"Não foi possivel conectar á API. \n Verifique se a API está rodando em: {ApiClientService.ApiBaseUrl} \n\nDetalhes: {ex.Message}", "Erro de conexão",MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        catch (Exception ex) 
        {
            MessageBox.Show($"Erro inesperado no login: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }

    }


    public async Task<UsuarioDto?> CadastrarUsuarioAsync(string nome, string email, string senha, string? fotoPerfil = null )
    {
        try
        {
            //payloading
            var payload = new CriarUsuarioDto {Nome = nome,  Email = email, Senha = senha, FotoPerfil = fotoPerfil };
            var response = await _http.PostAsJsonAsync("api/Usuario", payload);//dando post de usuário 

            if (response.IsSuccessStatusCode)
                return await response.Content.ReadFromJsonAsync<UsuarioDto>();//lê a resposta da API 

            //409 Conflito > e-mail já cadastrado
            var erro = await response.Content.ReadAsStringAsync();
            var msg = ExtrairMensagemErro(erro);
            MessageBox.Show(msg, "Erro ao cadastradar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
        catch (HttpRequestException ex)
        {

            MessageBox.Show($"Sem conexão com a API:`{ex.Message}", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null ;
        }

    }



    //comunicação entre api e front //esse ususario dto deve vir da UI
    public async Task<List<UsuarioDto>> ListarUsuarioAsync()
    {
        try
        {
            var lista = await _http.GetFromJsonAsync<List<UsuarioDto>>("api/usuario");//get de usuários ou seja traz todos 
            return lista ?? new List<UsuarioDto>();//polessencia nula
        }
        catch (HttpRequestException ex)// parâmetro instanciado para capturar todos os erros contido na linguagem
        {

            MessageBox.Show($"Sem conexão com a API: {ex.Message}","Erro de conexão API", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return new List<UsuarioDto>();
        }
    }


    // ──────────────────────────────────────────────────────────────────────────────
    // BUSCAR POR ID
    // ──────────────────────────────────────────────────────────────────────────────

    public async Task<UsuarioDto?> GetUsuarioByIdAsync(int id)
    {
        try
        {
            return await _http.GetFromJsonAsync<UsuarioDto>($"api/usuario/{id}");
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Erro ao buscar usuário: {ex.Message}",
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // ATUALIZAR USUÁRIO
    // ──────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Atualiza nome e email de um usuário existente.
    /// Retorna true em caso de sucesso.
    /// </summary>
    public async Task<bool> AtualizarUsuarioAsync(UsuarioDto dto)
    {
        try
        {
            var response = await _http.PutAsJsonAsync($"api/usuario/{dto.Id}", dto);

            if (response.IsSuccessStatusCode)
                return true;

            var erro = await response.Content.ReadAsStringAsync();
            MessageBox.Show(ExtrairMensagemErro(erro), "Erro ao Atualizar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Sem conexão com a API: {ex.Message}",
                "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    // ──────────────────────────────────────────────────────────────────────────────
    // EXCLUIR USUÁRIO
    // ──────────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Exclui um usuário existente.
    /// Retorna true em caso de sucesso.
    /// </summary>
    public async Task<bool> ExcluirUsuarioAsync(int id)
    {
        try
        {
            var response = await _http.DeleteAsync($"api/usuario/{id}");

            if (response.IsSuccessStatusCode)
                return true;

            var erro = await response.Content.ReadAsStringAsync();
            MessageBox.Show(ExtrairMensagemErro(erro), "Erro ao Excluir",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }
        catch (HttpRequestException ex)
        {
            MessageBox.Show($"Sem conexão com a API: {ex.Message}",
                "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }


    // ──────────────────────────────────────────────────────────────────────────────
    // UPLOAD DE FOTO
    // ──────────────────────────────────────────────────────────────────────────────
    public async Task<string?> UploadFotoAsync(string filePath)
    {
        try
        {
            using var form = new MultipartFormDataContent();
            using var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            using var streamContent = new StreamContent(fileStream);
            var contentType = Path.GetExtension(filePath).ToLowerInvariant() == ".png" ? "image/png" : "image/jpeg";
            streamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
            form.Add(streamContent, "file", Path.GetFileName(filePath));

            var response = await _http.PostAsync("api/upload/usuario", form);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<UploadResponseDto>(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return result?.Caminho;
            }

            var erro = await response.Content.ReadAsStringAsync();
            MessageBox.Show(ExtrairMensagemErro(erro), "Erro no Upload", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao enviar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }




    private static string ExtrairMensagemErro(string json) //mensagem de erro JSON
    {
        try
        {
            var doc = JsonDocument.Parse(json);
            if (doc.RootElement.TryGetProperty("mensagem", out var m))
                return m.GetString() ?? json;//se não tiverr mensagem 
        }
        catch { /*Retornar o texto bruto */}
        

            return json;// se não for um Jsom válido
        
    }



}



    

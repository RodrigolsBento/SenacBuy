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



    

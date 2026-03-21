using SenacBuy.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;

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
    

}

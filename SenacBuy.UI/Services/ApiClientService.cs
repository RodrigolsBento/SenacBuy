using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SenacBuy.UI.Services;

public static class ApiClientService //não precisa instanciar se for statico
{
    public const string ApiBaseUrl = "http://localhost:5231";

    private static readonly HttpClient _httpClient = CriarHttpClient(); //criar o http client  corretamente 


    //Segundo passo é criar uma propriedade pública para acessar o http client criado,
    //para ser usado em outras partes do aplicativo, como os serviços de consumo da API
    public static HttpClient Cliente => _httpClient; //propriedade para acessar o http client criado, para ser usado em outras partes do aplicativo, como os serviços de consumo da API


    //Primiero passo é criar o http client, para isso criamos um método privado que configura o cliente 
    private static HttpClient CriarHttpClient()
    {

        var cliente = new HttpClient();
        
            cliente.BaseAddress = new Uri(ApiBaseUrl);

        //Informamos a API que esperamos resposta JSON
        cliente.DefaultRequestHeaders.Accept.Clear();//cabeçalhos de requisição, limpa os cabeçalhos de aceitação
        cliente.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//adiciona um cabeçalho de aceitação para indicar que esperamos resposta JSON

        cliente.Timeout = TimeSpan.FromSeconds(30); //definir um tempo limite para as requisições, evitando que o aplicativo fique travado esperando por uma resposta indefinidamente

        return cliente;//devolve todos os ends points, simula o swagger 

    }


}

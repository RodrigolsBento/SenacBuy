
using SenacBuy.Application.DTOs;
using SenacBuy.Domain.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace SenacBuy.Application.Services;

public class UsuarioService
{

    //regras de negócio para o usuário


    //injetar
    private readonly IUsuarioRepository _usuarioRepository;//objeto da interface 

    //contrutor, não tem retorno e é identica a classe 
    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    //MET. ASÍNCRONO task é o tipo     passar o parâmetro
    public async Task<LoginResponseDto> AutenticarAsync(LoginDto loginDto)
    {
        var usuario = await _usuarioRepository.ObterPorEmailAsync(loginDto.Email);
        if (usuario == null)
        {
            return new LoginResponseDto
            {
                Sucesso = false,
                Mensagem = "E-mail não encontrado"
            };
            
        }

        //entra no banco criptograda e será verificado criptografada 
        var senHashFornecida = GerarHash(loginDto.Senha);

    }


    private static string GerarHash(string texto)
    {
        var byts = SHA256.HashData(Encoding.UTF8.GetBytes(texto));//habilitar o using System.Text; para Encoding funcionar
        return Convert.ToHexString(byts).ToLower();//aqui é o hash gerado que será normalizado e não a senha 
    }



}

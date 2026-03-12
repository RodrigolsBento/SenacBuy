
using SenacBuy.Application.DTOs;
using SenacBuy.Domain.Entities;
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

    //MET. ASÍNCRONO task é o tipo     passar o parâmetro // validação/ autenticação de login de usuário
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
        var senhaHashFornecida = GerarHash(loginDto.Senha);
        if (usuario.SenhaHash != senhaHashFornecida)
        {
            return new LoginResponseDto
            {
                Sucesso = false,
                Mensagem = "E-mail não encontrado"
            };
        }

        //após as duas respostas de erro, se chegar aqui é porque o login foi bem-sucedido, então retorna os dados do usuário e a mensagem de sucesso
        return new LoginResponseDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            Sucesso = true,
            Mensagem = "Autenticação bem-sucedida"
        };

    }


    //método para criar um novo usuário, onde o parâmetro é um objeto do tipo CriarUsuarioDto,
    //que contém as informações necessárias para criar um novo usuário, como nome, email, senha e foto de perfil.
    //O método é assíncrono e retorna um objeto do tipo UsuarioDto, que representa os dados do usuário criado.
    public async Task <UsuarioDto> CriarAsync(CriarUsuarioDto dto )
    {
        //verificar se o email já existe
        var existente = await _usuarioRepository.ObterPorEmailAsync(dto.Email);
        if (existente != null)
        {
            throw new InvalidOperationException($"Já existe usuário com e-mail '{dto.Email}' . ");
        }

        //quando a confirmação for feita, cria-se um novo objeto do tipo usuário, onde o nome, email e foto de perfil são passados diretamente do dto, mas a senha é processada por um método de geração de hash para garantir que a senha seja armazenada de forma segura no banco de dados. O hash é uma representação criptografada da senha original, o que aumenta a segurança dos dados do usuário.
        var usuario = new Usuario
        {
            Nome = dto.Nome,
            Email = dto.Email,
            SenhaHash = GerarHash(dto.Senha), 
            FotoPerfil = dto.FotoPerfil
        };

        //metodo para criar o usuário no banco de dados, onde o objeto do tipo usuário é passado como parâmetro. O método CriarAsync é responsável por persistir os dados do usuário no banco de dados, garantindo que as informações sejam armazenadas de forma segura e eficiente.

        await _usuarioRepository.AdicionarAsync(usuario);

        //retorno para retira o erro 

        return new UsuarioDto // foi no banco inseriu e está trasendo agora do banco de dados 
        {
            Id = usuario.Id,//verificação por conta do aidentiti
            Nome = usuario.Nome,
            Email = usuario.Email,
            FotoPerfil = usuario.FotoPerfil
        };

    }


   
    //listar todos os usuários
    public async Task<IEnumerable<UsuarioDto>> ListarTodosAsync ()
    {

        var usuarios = await _usuarioRepository.ListarTodosAsync();
        return usuarios.Select(usuario => new UsuarioDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            FotoPerfil = usuario.FotoPerfil

        }); //na interface do dto está personalizado 

    }


    //Obter por ID
    public async Task<UsuarioDto?> ObterPorIdAsync(int id)
    {

        var usuario = await _usuarioRepository.ObterPorIdAsync(id);

        if (usuario == null) return null;

        return new UsuarioDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            FotoPerfil = usuario.FotoPerfil

        }; //na interface do dto está personalizado 

    }
   
    
    public async Task RemoverAsync(int id)
    {

        var usuario = await _usuarioRepository.ObterPorIdAsync(id);
        if (usuario == null)
        
            throw new InvalidOperationException($"Usuário com ID '{id}' não encontrado.");
        
        await _usuarioRepository.RemoverAsync(id);

    }


    public async Task <UsuarioDto?> UpdateAsync(UsuarioDto dto)
    {
        //1 - passo :buscar id do usuário 
        var usuario = await _usuarioRepository.ObterPorIdAsync(dto.Id);

        //2 - passo se o usuário é nulo ou não
        if (usuario == null)
            return null;
        //3 - passo : atualizar os dados do usuário com as informações fornecidas no dto
        usuario.Nome = dto.Nome;
        usuario.Email = dto.Email;
        if (dto.FotoPerfil != null)
        {
            usuario.FotoPerfil = dto.FotoPerfil;
        }

        //4 - passo : salvar as alterações no banco, persistir no banco 
        await _usuarioRepository.AtualizarAsync(usuario);

        //5 - passo : retornar um novo objeto do tipo UsuarioDto com os dados atualizados do usuário
        return new UsuarioDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            FotoPerfil = usuario.FotoPerfil
        };


    }




    private static string GerarHash(string texto)
    {
        var byts = SHA256.HashData(Encoding.UTF8.GetBytes(texto));//habilitar o using System.Text; para Encoding funcionar
        return Convert.ToHexString(byts).ToLower();//aqui é o hash gerado que será normalizado e não a senha 
    }



}

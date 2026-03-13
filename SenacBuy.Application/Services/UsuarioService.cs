using System.Security.Cryptography;
using System.Text;
using SenacBuy.Application.DTOs;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;

namespace SenacBuy.Application.Services;

/// <summary>
/// Service responsável pela lógica de negócio relacionada a usuários.
/// Inclui criação de conta, autenticação (login) e gerenciamento.
/// 
/// ATENÇÃO DIDÁTICA: Este service recebe e retorna DTOs - nunca entidades diretamente.
/// A conversão entre DTO e entidade acontece aqui, protegendo a camada de domain
/// de ser exposta diretamente para fora.
/// </summary>
public class UsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    /// <summary>
    /// Autentica um usuário verificando email e senha (hash).
    /// Fluxo: compara o hash da senha digitada com o hash armazenado.
    /// </summary>
    public async Task<LoginResponseDto> AutenticarAsync(LoginDto loginDto)
    {
        // 1. Busca o usuário pelo email
        var usuario = await _usuarioRepository.ObterPorEmailAsync(loginDto.Email);

        if (usuario == null)
        {
            return new LoginResponseDto
            {
                Sucesso = false,
                Mensagem = "Email não encontrado."
            };
        }

        // 2. Gera o hash da senha fornecida e compara com o hash armazenado
        var senhaHashFornecida = GerarHash(loginDto.Senha);
        if (usuario.SenhaHash != senhaHashFornecida)
        {
            return new LoginResponseDto
            {
                Sucesso = false,
                Mensagem = "Senha incorreta."
            };
        }

        return new LoginResponseDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            Sucesso = true,
            Mensagem = "Login realizado com sucesso.",
            FotoPerfil = usuario.FotoPerfil
        };
    }

    /// <summary>Cria um novo usuário, validando unicidade do email</summary>
    public async Task<UsuarioDto> CriarAsync(CriarUsuarioDto dto)
    {
        // Regra de negócio: email deve ser único
        var existente = await _usuarioRepository.ObterPorEmailAsync(dto.Email);
        if (existente != null)
            throw new InvalidOperationException($"Já existe um usuário com o email '{dto.Email}'.");

        var usuario = new Usuario
        {
            Nome = dto.Nome,
            Email = dto.Email,
            SenhaHash = GerarHash(dto.Senha), // Converte para hash antes de salvar
            FotoPerfil = dto.FotoPerfil
        };

        await _usuarioRepository.AdicionarAsync(usuario);

        return new UsuarioDto { Id = usuario.Id, Nome = usuario.Nome, Email = usuario.Email, FotoPerfil = usuario.FotoPerfil };
    }

    public async Task<IEnumerable<UsuarioDto>> ListarTodosAsync()
    {
        var usuarios = await _usuarioRepository.ListarTodosAsync();
        return usuarios.Select(u => new UsuarioDto
        {
            Id = u.Id,
            Nome = u.Nome,
            Email = u.Email,
            FotoPerfil = u.FotoPerfil
        });
    }

    public async Task<UsuarioDto?> ObterPorIdAsync(int id)
    {
        var u = await _usuarioRepository.ObterPorIdAsync(id);
        if (u == null) return null;

        return new UsuarioDto
        {
            Id = u.Id,
            Nome = u.Nome,
            Email = u.Email,
            FotoPerfil = u.FotoPerfil
        };
    }

    public async Task RemoverAsync(int id)
    {
        var usuario = await _usuarioRepository.ObterPorIdAsync(id);
        if (usuario == null)
            throw new KeyNotFoundException($"Usuário com Id {id} não encontrado.");

        await _usuarioRepository.RemoverAsync(id);
    }

    /// <summary>
    /// Atualiza Nome e Email de um usuário existente.
    /// SenhaHash nunca é alterada por este método — troca de senha requer fluxo próprio.
    /// Retorna null se o usuário não for encontrado.
    /// </summary>
    public async Task<UsuarioDto?> UpdateAsync(UsuarioDto dto)
    {
        // 1. Busca o usuário pelo Id informado no DTO
        var usuario = await _usuarioRepository.ObterPorIdAsync(dto.Id);

        // 2. Retorna null → Controller responderá 404 NotFound
        if (usuario == null)
            return null;

        // 3. Aplica as alterações permitidas (SenhaHash permanece intocada)
        usuario.Nome = dto.Nome;
        usuario.Email = dto.Email;
        if (dto.FotoPerfil != null)
        {
            usuario.FotoPerfil = dto.FotoPerfil;
        }

        // 4. Persiste no banco via repositório
        await _usuarioRepository.AtualizarAsync(usuario);

        // 5. Retorna o DTO atualizado
        return new UsuarioDto
        {
            Id = usuario.Id,
            Nome = usuario.Nome,
            Email = usuario.Email,
            FotoPerfil = usuario.FotoPerfil
        };
    }

    /// <summary>
    /// Gera hash SHA256 da senha.
    /// ATENÇÃO DIDÁTICA: Para produção real, use BCrypt ou Argon2.
    /// SHA256 é usado aqui por simplicidade educacional.
    /// </summary>
    private static string GerarHash(string texto)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
        return Convert.ToHexString(bytes).ToLower();
    }
}

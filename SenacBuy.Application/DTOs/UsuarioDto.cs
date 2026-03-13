namespace SenacBuy.Application.DTOs;

/// <summary>DTOs de Usuário para comunicação entre camadas</summary>

/// <summary>Dados para criar ou retornar um usuário (sem a senha)</summary>
public class UsuarioDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string? FotoPerfil { get; set; }
}

/// <summary>Dados para criar um novo usuário (inclui a senha em texto plano)</summary>
public class CriarUsuarioDto
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    /// <summary>Senha em texto puro - será convertida em hash pelo Service</summary>
    public string Senha { get; set; } = string.Empty;
    public string? FotoPerfil { get; set; }
}

/// <summary>Dados para autenticação (login)</summary>
public class LoginDto
{
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}

/// <summary>Resposta após login bem-sucedido</summary>
public class LoginResponseDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Sucesso { get; set; }
    public string Mensagem { get; set; } = string.Empty;
    public string? FotoPerfil { get; set; }
}

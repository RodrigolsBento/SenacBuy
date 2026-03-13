namespace SenacBuy.Domain.Entities;

/// <summary>
/// Entidade que representa um usuário do sistema.
/// Usuários são responsáveis por operar o sistema (funcionários, administradores).
/// </summary>
public class Usuario
{
    public int Id { get; set; }

    /// <summary>Nome completo do usuário</summary>
    public string Nome { get; set; } = string.Empty;

    /// <summary>
    /// Email único do usuário. Será utilizado como login.
    /// Regra de negócio: não pode haver dois usuários com o mesmo email.
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Senha armazenada como hash.
    /// ATENÇÃO: Em produção real, utilize BCrypt ou argon2.
    /// Para fins didáticos, utilizamos SHA256.
    /// </summary>
    public string SenhaHash { get; set; } = string.Empty;

    /// <summary>
    /// Caminho relativo para a foto de perfil do usuário.
    /// Opcional, salvo dentro de uploads/usuarios.
    /// </summary>
    public string? FotoPerfil { get; set; }
}

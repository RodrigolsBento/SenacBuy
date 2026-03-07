namespace SenacBuy.Application.DTOs;

public class UsuarioDto
{
    public int Id { get; set; }

    public string Nome { get; set; } = string.Empty;    

    public string Email { get; set; } = string.Empty;

}

//criar usuario
public class CriarUsuarioDto
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}
public class LoginDto
{
   
    public string Email { get; set; } = string.Empty;
    public string Senha { get; set; } = string.Empty;
}
public class LoginResponseDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public bool Sucesso { get; set; }

    public string Mensagem { get; set; } = string.Empty;
}

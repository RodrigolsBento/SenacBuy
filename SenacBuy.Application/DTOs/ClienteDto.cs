namespace SenacBuy.Application.DTOs;

/// <summary>DTOs de Cliente para comunicação entre camadas</summary>

public class ClienteDto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
}

public class CriarClienteDto
{
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
}

public class AtualizarClienteDto
{
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
}

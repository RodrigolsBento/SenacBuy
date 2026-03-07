namespace SenacBuy.Application.DTOs;

public class ClienteDto //através da DTO eu acesso o domain e o preservo a integridade do domain, ou seja, não exponho o domain para o mundo externo, e sim a DTO, que é uma representação do domain, e a DTO tem a função de transportar os dados entre as camadas da aplicação, ou seja, entre o domain e o presentation, ou seja, entre o back e o front, ou seja, entre o servidor e o cliente, ou seja, entre o banco de dados e a aplicação, ou seja, entre o usuário e a aplicação, ou seja, entre o sistema e o usuário.
{
    //representação lógica, porém não tem todos os atributos do domain, ou seja, tem apenas os atributos que são necessários para a aplicação, ou seja, tem apenas os atributos que são necessários para o front, ou seja, tem apenas os atributos que são necessários para o usuário, ou seja, tem apenas os atributos que são necessários para o sistema, ou seja, tem apenas os atributos que são necessários para a aplicação.
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string CPF { get; set; } = string.Empty;
}

//DTOs de criação e atualização, ou seja, DTOs de entrada, ou seja, DTOs de request, DTOs de comando de criação e atualização, ou seja, DTOs de comando de criação e atualização de cliente.
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

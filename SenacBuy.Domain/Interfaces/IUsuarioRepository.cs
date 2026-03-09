using SenacBuy.Domain.Entities;

namespace SenacBuy.Domain.Interfaces;

public  interface IUsuarioRepository
{
    //operações assincrona <Tipo/retorno do método/tipagem>
    Task <Usuario?> ObterPorIdAsync(int id);//método para obter um usuário por id, retornando um objeto do tipo Usuario ou null se não encontrado

    Task<Usuario?> ObterPorEmailAsync (string email);//método para obter um usuário por email, retornando um objeto do tipo Usuario ou null se não encontrado

    Task<IEnumerable<Usuario?>> ListarTodosAsync();//método para listar todos os usuários, retornando uma lista de objetos do tipo Usuario

    Task AdicionarAsync(Usuario usuario);//método para adicionar um novo usuário, recebendo um objeto do tipo Usuario e retornando a tarefa assíncrona

    Task AtualizarAsync(Usuario usuario);//método para atualizar um usuário existente, recebendo um objeto do tipo Usuario e retornando a tarefa assíncrona

    Task RemoverAsync(Usuario usuario);
}

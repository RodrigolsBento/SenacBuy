using Microsoft.AspNetCore.Mvc;
using SenacBuy.Application.DTOs;
using SenacBuy.Application.Services;

namespace SenacBuy.API.Controllers;

public class UsuarioController : ControllerBase
{

    private readonly UsuarioService _usuarioService;//será injetado no programa.cs


    public UsuarioController(UsuarioService usuarioservice)//metodo construtor
    {
        _usuarioService = usuarioservice;
    }


    /// <summary>
    /// Realiza o login do usuário.
    /// valida email e senha (hash da senha) e retorna os dados do usuário autenticado.
    /// </summary>

    //login do usuário, estou enviando uma requisção um post 
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        try
        {
            var resultado = await _usuarioService.AutenticarAsync(loginDto);
            if (!resultado.Sucesso ) //se não retornou sucesso 
                return Unauthorized(resultado.Mensagem);
            return Ok(resultado);

        }
        catch (Exception ex)
        {

            return BadRequest(new {mensagem = ex.Message});//parte do controller base 
        }
    }


    //listar 
    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
      var usuarios = await _usuarioService.ListarTodosAsync();
        return Ok(usuarios);
    }

    [HttpGet("{id}")]//rota para listar por id, interpolação de string sem sifrão
        public async Task<IActionResult> ObterPorId(int id)
    {
        var usuario = await _usuarioService.ObterPorIdAsync(id);
        if (usuario == null)
            return NotFound(new {mensagem = $"Usuário {id}  não foi encontrado"});
        return Ok(usuario);
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarUsuarioDto dto)
    {
        try
        {

            var usuario = await _usuarioService.CriarAsync(dto);
            return CreatedAtAction(nameof(ListarTodos), new { id = usuario.Id }, usuario);
        }
        catch (Exception ex)
        {

            return Conflict(new { mensagem = ex.Message });//caso já tenha usuário 
        }
        
    }


    [HttpDelete ("{id}")]
    public async Task<IActionResult> Remover(int id)
    {
        try
        {
            await _usuarioService.RemoverAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { mensagem = ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UsuarioDto dto)
    {
       if (id != dto.Id)
            return BadRequest(new { mensagem = "O ID da rota não corresponde ao ID do corpo da requisição" });
       
        
            var usuarioAtualizado = await _usuarioService.UpdateAsync(dto);
            return Ok(usuarioAtualizado);

        if (usuarioAtualizado == null)
            return NotFound(new { mensagem = $"Usuário {id} não encontrado" }); 

    }


}

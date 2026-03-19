using Microsoft.AspNetCore.Mvc;
using SenacBuy.Application.DTOs;
using SenacBuy.Application.Services;

namespace SenacBuy.API.Controllers;

/// <summary>
/// Controller CRUD completo para Pedidos.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly PedidoService _pedidoService;

    public PedidoController(PedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    [HttpGet]
    public async Task<IActionResult> ListarTodos()
    {
        var pedidos = await _pedidoService.ListarTodosAsync();
        return Ok(pedidos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObterPorId(int id)
    {
        var pedido = await _pedidoService.ObterPorIdAsync(id);
        if (pedido == null) return NotFound(new { mensagem = $"Pedido {id} não encontrado." });
        return Ok(pedido);
    }

    [HttpGet("cliente/{clienteId}")]
    public async Task<IActionResult> ListarPorCliente(int clienteId)
    {
        var pedidos = await _pedidoService.ListarPorClienteAsync(clienteId);
        return Ok(pedidos);
    }

    [HttpPost]
    public async Task<IActionResult> Criar([FromBody] CriarPedidoDto dto)
    {
        try
        {
            var pedido = await _pedidoService.CriarAsync(dto);
            return CreatedAtAction(nameof(ObterPorId), new { id = pedido.Id }, pedido);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { mensagem = ex.Message });
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { mensagem = ex.Message });
        }
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Atualizar(int id, [FromBody] AtualizarPedidoDto dto)
    {
        try
        {
            var pedido = await _pedidoService.AtualizarAsync(id, dto);
            return Ok(pedido);
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { mensagem = ex.Message });
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(new { mensagem = ex.Message });
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remover(int id)
    {
        try
        {
            await _pedidoService.RemoverAsync(id);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(new { mensagem = ex.Message });
        }
    }
}

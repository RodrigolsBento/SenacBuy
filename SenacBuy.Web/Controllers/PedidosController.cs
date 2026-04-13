using Microsoft.AspNetCore.Mvc;
using SenacBuy.Web.Models;
using SenacBuy.Web.Services;

namespace SenacBuy.Web.Controllers;

public class PedidosController : Controller
{
    private readonly PedidoApiService  _pedidoService;
    private readonly ClienteApiService _clienteService;
    private readonly ProdutoApiService _produtoService;

    public PedidosController(PedidoApiService pedidoService, ClienteApiService clienteService, ProdutoApiService produtoService)
    {
        _pedidoService  = pedidoService;
        _clienteService = clienteService;
        _produtoService = produtoService;
    }

    // GET /Pedidos
    public async Task<IActionResult> Index(string? status)
    {
        var pedidos = await _pedidoService.ListarAsync();

        if (!string.IsNullOrWhiteSpace(status) && status != "Todos")
            pedidos = pedidos.Where(p => p.Status == status).ToList();

        ViewBag.StatusAtual = status ?? "Todos";
        return View(pedidos);
    }

    // GET /Pedidos/Criar
    public async Task<IActionResult> Criar()
    {
        ViewBag.Clientes = await _clienteService.ListarAsync();
        ViewBag.Produtos  = await _produtoService.ListarAsync();
        return View("Form", new PedidoViewModel());
    }

    // POST /Pedidos/Criar
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(PedidoViewModel vm)
    {
        // Remove validação de itens vindos do form
        ModelState.Remove("NomeCliente");

        if (!ModelState.IsValid || !vm.Itens.Any())
        {
            if (!vm.Itens.Any())
                ModelState.AddModelError("", "Adicione ao menos um item ao pedido.");
            ViewBag.Clientes = await _clienteService.ListarAsync();
            ViewBag.Produtos  = await _produtoService.ListarAsync();
            return View("Form", vm);
        }

        var ok = await _pedidoService.CriarAsync(vm);
        if (!ok)
        {
            ModelState.AddModelError("", "Erro ao criar pedido.");
            ViewBag.Clientes = await _clienteService.ListarAsync();
            ViewBag.Produtos  = await _produtoService.ListarAsync();
            return View("Form", vm);
        }

        TempData["Sucesso"] = "Pedido criado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // GET /Pedidos/Editar/5
    public async Task<IActionResult> Editar(int id)
    {
        var vm = await _pedidoService.ObterPorIdAsync(id);
        if (vm == null) return NotFound();
        ViewBag.Clientes = await _clienteService.ListarAsync();
        ViewBag.Produtos  = await _produtoService.ListarAsync();
        return View("Form", vm);
    }

    // POST /Pedidos/Editar/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(PedidoViewModel vm)
    {
        ModelState.Remove("NomeCliente");

        if (!ModelState.IsValid || !vm.Itens.Any())
        {
            if (!vm.Itens.Any())
                ModelState.AddModelError("", "Adicione ao menos um item ao pedido.");
            ViewBag.Clientes = await _clienteService.ListarAsync();
            ViewBag.Produtos  = await _produtoService.ListarAsync();
            return View("Form", vm);
        }

        var ok = await _pedidoService.AtualizarAsync(vm);
        if (!ok)
        {
            ModelState.AddModelError("", "Erro ao atualizar pedido.");
            ViewBag.Clientes = await _clienteService.ListarAsync();
            ViewBag.Produtos  = await _produtoService.ListarAsync();
            return View("Form", vm);
        }

        TempData["Sucesso"] = "Pedido atualizado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // POST /Pedidos/Excluir/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        await _pedidoService.RemoverAsync(id);
        TempData["Sucesso"] = "Pedido excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // GET /Pedidos/Recibo/5
    public async Task<IActionResult> Recibo(int id)
    {
        var vm = await _pedidoService.ObterPorIdAsync(id);
        if (vm == null) return NotFound();
        return View(vm);
    }
}

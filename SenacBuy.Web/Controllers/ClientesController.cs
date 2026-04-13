using Microsoft.AspNetCore.Mvc;
using SenacBuy.Web.Models;
using SenacBuy.Web.Services;

namespace SenacBuy.Web.Controllers;

public class ClientesController : Controller
{
    private readonly ClienteApiService _service;

    public ClientesController(ClienteApiService service)
        => _service = service;

    // GET /Clientes
    public async Task<IActionResult> Index(string? busca)
    {
        var clientes = await _service.ListarAsync();

        if (!string.IsNullOrWhiteSpace(busca))
            clientes = clientes.Where(c =>
                c.Nome.Contains(busca, StringComparison.OrdinalIgnoreCase) ||
                c.CPF.Contains(busca, StringComparison.OrdinalIgnoreCase)).ToList();

        ViewBag.Busca = busca;
        return View(clientes);
    }

    // GET /Clientes/Criar
    public IActionResult Criar() => View("Form", new ClienteViewModel());

    // POST /Clientes/Criar
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(ClienteViewModel vm)
    {
        if (!ModelState.IsValid) return View("Form", vm);

        var ok = await _service.CriarAsync(vm);
        if (!ok) { ModelState.AddModelError("", "Erro ao criar cliente."); return View("Form", vm); }

        TempData["Sucesso"] = "Cliente criado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // GET /Clientes/Editar/5
    public async Task<IActionResult> Editar(int id)
    {
        var vm = await _service.ObterPorIdAsync(id);
        if (vm == null) return NotFound();
        return View("Form", vm);
    }

    // POST /Clientes/Editar/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(ClienteViewModel vm)
    {
        if (!ModelState.IsValid) return View("Form", vm);

        var ok = await _service.AtualizarAsync(vm);
        if (!ok) { ModelState.AddModelError("", "Erro ao atualizar cliente."); return View("Form", vm); }

        TempData["Sucesso"] = "Cliente atualizado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // POST /Clientes/Excluir/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        await _service.RemoverAsync(id);
        TempData["Sucesso"] = "Cliente excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }
}

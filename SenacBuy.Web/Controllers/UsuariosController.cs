using Microsoft.AspNetCore.Mvc;
using SenacBuy.Web.Models;
using SenacBuy.Web.Services;

namespace SenacBuy.Web.Controllers;

public class UsuariosController : Controller
{
    private readonly UsuarioApiService _service;

    public UsuariosController(UsuarioApiService service)
        => _service = service;

    // GET /Usuarios
    public async Task<IActionResult> Index()
    {
        var usuarios = await _service.ListarAsync();
        return View(usuarios);
    }

    // GET /Usuarios/Criar
    public IActionResult Criar() => View("Form", new UsuarioViewModel());

    // POST /Usuarios/Criar
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(UsuarioViewModel vm, IFormFile? foto)
    {
        if (!ModelState.IsValid) return View("Form", vm);

        var ok = await _service.CriarAsync(vm);
        if (!ok) { ModelState.AddModelError("", "Erro ao criar usuário."); return View("Form", vm); }

        // Upload de foto após criação
        if (foto != null && foto.Length > 0)
        {
            var usuarios = await _service.ListarAsync();
            var novo = usuarios.Where(u => u.Email == vm.Email).MaxBy(u => u.Id);
            if (novo != null)
                await _service.UploadFotoAsync(novo.Id, foto);
        }

        TempData["Sucesso"] = "Usuário criado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // GET /Usuarios/Editar/5
    public async Task<IActionResult> Editar(int id)
    {
        var vm = await _service.ObterPorIdAsync(id);
        if (vm == null) return NotFound();
        return View("Form", vm);
    }

    // POST /Usuarios/Editar/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(UsuarioViewModel vm, IFormFile? foto)
    {
        // Senha não é obrigatória na edição
        ModelState.Remove("Senha");

        if (!ModelState.IsValid) return View("Form", vm);

        // Upload de foto se enviada
        if (foto != null && foto.Length > 0)
        {
            var caminho = await _service.UploadFotoAsync(vm.Id, foto);
            if (caminho != null) vm.FotoPerfil = caminho;
        }

        var ok = await _service.AtualizarAsync(vm);
        if (!ok) { ModelState.AddModelError("", "Erro ao atualizar usuário."); return View("Form", vm); }

        TempData["Sucesso"] = "Usuário atualizado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // POST /Usuarios/Excluir/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        await _service.RemoverAsync(id);
        TempData["Sucesso"] = "Usuário excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }
}

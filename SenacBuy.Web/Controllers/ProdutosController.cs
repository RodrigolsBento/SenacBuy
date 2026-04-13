using Microsoft.AspNetCore.Mvc;
using SenacBuy.Web.Models;
using SenacBuy.Web.Services;

namespace SenacBuy.Web.Controllers;

public class ProdutosController : Controller
{
    private readonly ProdutoApiService   _produtoService;
    private readonly CategoriaApiService _categoriaService;

    public ProdutosController(ProdutoApiService produtoService, CategoriaApiService categoriaService)
    {
        _produtoService   = produtoService;
        _categoriaService = categoriaService;
    }

    // GET /Produtos
    public async Task<IActionResult> Index(string? busca)
    {
        var produtos = await _produtoService.ListarAsync();

        if (!string.IsNullOrWhiteSpace(busca))
            produtos = produtos.Where(p =>
                p.Nome.Contains(busca, StringComparison.OrdinalIgnoreCase) ||
                (p.CategoriaNome != null && p.CategoriaNome.Contains(busca, StringComparison.OrdinalIgnoreCase))).ToList();

        ViewBag.Busca = busca;
        return View(produtos);
    }

    // GET /Produtos/Criar
    public async Task<IActionResult> Criar()
    {
        ViewBag.Categorias = await _categoriaService.ListarAsync();
        return View("Form", new ProdutoViewModel());
    }

    // POST /Produtos/Criar
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(ProdutoViewModel vm, IFormFile? foto)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categorias = await _categoriaService.ListarAsync();
            return View("Form", vm);
        }

        var ok = await _produtoService.CriarAsync(vm);
        if (!ok)
        {
            ModelState.AddModelError("", "Erro ao criar produto.");
            ViewBag.Categorias = await _categoriaService.ListarAsync();
            return View("Form", vm);
        }

        // Se enviou foto, busca o novo produto para obter o ID e faz upload
        if (foto != null && foto.Length > 0)
        {
            var produtos = await _produtoService.ListarAsync();
            var novo = produtos.Where(p => p.Nome == vm.Nome).MaxBy(p => p.Id);
            if (novo != null)
                await _produtoService.UploadFotoAsync(novo.Id, foto);
        }

        TempData["Sucesso"] = "Produto criado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // GET /Produtos/Editar/5
    public async Task<IActionResult> Editar(int id)
    {
        var vm = await _produtoService.ObterPorIdAsync(id);
        if (vm == null) return NotFound();
        ViewBag.Categorias = await _categoriaService.ListarAsync();
        return View("Form", vm);
    }

    // POST /Produtos/Editar/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Editar(ProdutoViewModel vm, IFormFile? foto)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categorias = await _categoriaService.ListarAsync();
            return View("Form", vm);
        }

        // Se enviou nova foto, faz upload antes de salvar
        if (foto != null && foto.Length > 0)
        {
            var caminho = await _produtoService.UploadFotoAsync(vm.Id, foto);
            if (caminho != null) vm.FotoProduto = caminho;
        }

        var ok = await _produtoService.AtualizarAsync(vm);
        if (!ok)
        {
            ModelState.AddModelError("", "Erro ao atualizar produto.");
            ViewBag.Categorias = await _categoriaService.ListarAsync();
            return View("Form", vm);
        }

        TempData["Sucesso"] = "Produto atualizado com sucesso!";
        return RedirectToAction(nameof(Index));
    }

    // POST /Produtos/Excluir/5
    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> Excluir(int id)
    {
        await _produtoService.RemoverAsync(id);
        TempData["Sucesso"] = "Produto excluído com sucesso!";
        return RedirectToAction(nameof(Index));
    }
}

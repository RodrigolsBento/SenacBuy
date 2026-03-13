using SenacBuy.Application.DTOs;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;
using SenacBuy.Domain.Entities;
using System.Text;

namespace SenacBuy.Application.Services;

/// <summary>
/// Service responsável pelas operações de Produto.
/// Aplica regra: preço não pode ser negativo.
/// </summary>
public class ProdutoService
{
    private readonly IProdutoRepository _produtoRepository;

    public ProdutoService(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    public async Task<IEnumerable<ProdutoDto>> ListarTodosAsync()
    {
        var produtos = await _produtoRepository.ListarTodosAsync();
        return produtos.Select(p => new ProdutoDto
        {
            Id = p.Id,
            Nome = p.Nome,
            Preco = p.Preco,
            FotoProduto = p.FotoProduto
        });
    }

    public async Task<ProdutoDto?> ObterPorIdAsync(int id)
    {
        var produto = await _produtoRepository.ObterPorIdAsync(id);
        if (produto == null) return null;

        return new ProdutoDto { Id = produto.Id, Nome = produto.Nome, Preco = produto.Preco, FotoProduto = produto.FotoProduto };
    }

    public async Task<ProdutoDto> CriarAsync(CriarProdutoDto dto)
    {
        // Regra de negócio: preço não pode ser negativo
        if (dto.Preco < 0)
            throw new InvalidOperationException("O preço do produto não pode ser negativo.");

        var produto = new Produto
        {
            Nome = dto.Nome,
            Preco = dto.Preco,
            FotoProduto = dto.FotoProduto
        };

        await _produtoRepository.AdicionarAsync(produto);

        return new ProdutoDto { Id = produto.Id, Nome = produto.Nome, Preco = produto.Preco, FotoProduto = produto.FotoProduto };
    }

    public async Task AtualizarAsync(int id, AtualizarProdutoDto dto)
    {
        var produto = await _produtoRepository.ObterPorIdAsync(id);
        if (produto == null)
            throw new KeyNotFoundException($"Produto com Id {id} não encontrado.");

        // Regra de negócio: preço não pode ser negativo
        if (dto.Preco < 0)
            throw new InvalidOperationException("O preço do produto não pode ser negativo.");

        produto.Nome = dto.Nome;
        produto.Preco = dto.Preco;
        if (dto.FotoProduto != null)
        {
            produto.FotoProduto = dto.FotoProduto;
        }

        await _produtoRepository.AtualizarAsync(produto);
    }

    public async Task RemoverAsync(int id)
    {
        var produto = await _produtoRepository.ObterPorIdAsync(id);
        if (produto == null)
            throw new KeyNotFoundException($"Produto com Id {id} não encontrado.");

        await _produtoRepository.RemoverAsync(id);
    }
}

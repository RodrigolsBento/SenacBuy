using SenacBuy.Application.DTOs;
using SenacBuy.Domain.Entities;
using SenacBuy.Domain.Interfaces;

namespace SenacBuy.Application.Services;

/// <summary>
/// Service responsável pelas operações de Cliente.
/// Aplica as regras de negócio antes de delegar para o repositório.
/// </summary>
public class ClienteService
{
    private readonly IClienteRepository _clienteRepository;

    public ClienteService(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    public async Task<IEnumerable<ClienteDto>> ListarTodosAsync()
    {
        var clientes = await _clienteRepository.ListarTodosAsync();
        return clientes.Select(c => new ClienteDto
        {
            Id = c.Id,
            Nome = c.Nome,
            CPF = c.CPF
        });
    }

    public async Task<ClienteDto?> ObterPorIdAsync(int id)
    {
        var cliente = await _clienteRepository.ObterPorIdAsync(id);
        if (cliente == null) return null;

        return new ClienteDto { Id = cliente.Id, Nome = cliente.Nome, CPF = cliente.CPF };
    }

    public async Task<ClienteDto> CriarAsync(CriarClienteDto dto)
    {
        // Regra de negócio: CPF único
        var existente = await _clienteRepository.ObterPorCPFAsync(dto.CPF);
        if (existente != null)
            throw new InvalidOperationException($"Já existe um cliente cadastrado com o CPF '{dto.CPF}'.");

        var cliente = new Cliente
        {
            Nome = dto.Nome,
            CPF = dto.CPF
        };

        await _clienteRepository.AdicionarAsync(cliente);

        return new ClienteDto { Id = cliente.Id, Nome = cliente.Nome, CPF = cliente.CPF };
    }

    public async Task AtualizarAsync(int id, AtualizarClienteDto dto)
    {
        var cliente = await _clienteRepository.ObterPorIdAsync(id);
        if (cliente == null)
            throw new KeyNotFoundException($"Cliente com Id {id} não encontrado.");

        // Verifica se outro cliente já usa este CPF
        var comMesmoCPF = await _clienteRepository.ObterPorCPFAsync(dto.CPF);
        if (comMesmoCPF != null && comMesmoCPF.Id != id)
            throw new InvalidOperationException($"O CPF '{dto.CPF}' já está em uso por outro cliente.");

        cliente.Nome = dto.Nome;
        cliente.CPF = dto.CPF;

        await _clienteRepository.AtualizarAsync(cliente);
    }

    public async Task RemoverAsync(int id)
    {
        var cliente = await _clienteRepository.ObterPorIdAsync(id);
        if (cliente == null)
            throw new KeyNotFoundException($"Cliente com Id {id} não encontrado.");

        await _clienteRepository.RemoverAsync(id);
    }
}

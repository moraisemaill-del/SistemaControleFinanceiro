using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SCF.Application.DTOs;
using SCF.Domain.Entities;
using SCF.Infrastructure.Data;

namespace SCF.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TransacoesController : ControllerBase
{
    private readonly AppDbContext _context;

    public TransacoesController(AppDbContext context)
    {
        _context = context;
    }

    // 1. CADASTRAR TRANSAÇÃO (POST)
    [HttpPost]
    public async Task<IActionResult> Cadastrar([FromBody] CriarTransacaoDto dto)
    {
        var usuarioExiste = await _context.Usuarios.FindAsync(dto.UsuarioId);
        if (usuarioExiste == null)
        {
            return BadRequest(new { mensagem = "Usuário informado não foi encontrado." });
        }

        var transacao = new Transacao
        {
            Id = 0, // O ID será gerado automaticamente pelo banco de dados
            Descricao = dto.Descricao,
            Valor = dto.Valor,
            Data = dto.Data,
            Tipo = dto.Tipo,
            UsuarioId = dto.UsuarioId
        };

        _context.Transacoes.Add(transacao);
        await _context.SaveChangesAsync();

        return Ok(new { mensagem = "Transação cadastrada com sucesso!", id = transacao.Id });
    }

    // 2. LISTAR TRANSAÇÕES DE UM USUÁRIO (GET)
    [HttpGet("usuario/{usuarioId}")]
    public async Task<IActionResult> ObterPorUsuario(int usuarioId)
    {
        var transacoes = await _context.Transacoes
            .Where(t => t.UsuarioId == usuarioId)
            .ToListAsync();

        return Ok(transacoes);
    }

    // 3. RESUMO FINANCEIRO / SALDO DO USUÁRIO (GET)
    [HttpGet("resumo/{usuarioId}")]
    public async Task<IActionResult> ObterResumo(int usuarioId)
    {
        var transacoes = await _context.Transacoes
            .Where(t => t.UsuarioId == usuarioId)
            .ToListAsync();

        // Calcula total de receitas (considerando "Receita" ignorando maiúsculas/minúsculas)
        var totalReceitas = transacoes
            .Where(t => t.Tipo.Equals("Receita", StringComparison.OrdinalIgnoreCase))
            .Sum(t => t.Valor);

        // Calcula total de despesas
        var totalDespesas = transacoes
            .Where(t => t.Tipo.Equals("Despesa", StringComparison.OrdinalIgnoreCase))
            .Sum(t => t.Valor);

        // Saldo = Receitas - Despesas
        var saldoAtual = totalReceitas - totalDespesas;

        return Ok(new
        {
            totalReceitas,
            totalDespesas,
            saldoAtual
        });
    }
}
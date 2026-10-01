using Microsoft.AspNetCore.Mvc;
using SCF.Application.DTOs;
using SCF.Domain.Entities;
using SCF.Infrastructure.Data;

namespace SCF.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Cadastrar([FromBody] CriarUsuarioDto dto)
    {
        var usuario = new Usuario
        {
            Nome = dto.Nome,
            Email = dto.Email,
            Senha = dto.Senha
        };

        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            mensagem = "Usuário cadastrado com sucesso!",
            id = usuario.Id
        });
    }
}
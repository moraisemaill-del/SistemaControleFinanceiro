namespace SCF.Application.DTOs;

public class CriarTransacaoDto
{
    public int UsuarioId { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public string Tipo { get; set; } = string.Empty; // "Receita" ou "Despesa"

}
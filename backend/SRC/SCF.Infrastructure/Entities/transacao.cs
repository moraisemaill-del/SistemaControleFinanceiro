namespace SCF.Domain.Entities;

public class Transacao
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public decimal Valor { get; set; }
    public DateTime Data { get; set; } = DateTime.UtcNow;
    public string Tipo { get; set; } = string.Empty; // "Receita" ou "Despesa"
    public string? Categoria { get; set; }

    public int UsuarioId { get; set; }
    public Usuario? Usuario { get; set; }
}

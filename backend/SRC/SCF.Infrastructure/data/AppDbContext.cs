using Microsoft.EntityFrameworkCore;
using SCF.Domain.Entities;

namespace SCF.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Transacao> Transacoes { get; set; }
//public DbSet<DividaMensal> DividasMensais { get; set; } // <-- Adicione esta linha

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Define que o campo Valor da Transacao tem 18 dígitos no total e 2 casas decimais (centavos)
        modelBuilder.Entity<Transacao>()
            .Property(t => t.Valor)
            .HasColumnType("decimal(18,2)");
    }
}
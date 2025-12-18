using IDNDev.Cadastros.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace IDNDev.Cadastros.Api.Data;

public class CadastroContext : DbContext
{
    public DbSet<Pessoa> Pessoas { get; set; }

    public CadastroContext(DbContextOptions<CadastroContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) 
        => modelBuilder.ApplyConfigurationsFromAssembly(typeof(CadastroContext).Assembly);
}

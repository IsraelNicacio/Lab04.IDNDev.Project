using IDNDev.Cadastros.Api.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IDNDev.Cadastros.Api.Data;

public class PessoaMapping : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(120)");

        builder.Property(p => p.Documento)
            .IsRequired()
            .HasColumnType("varchar(14)");

        builder.ToTable("Pessoas", "Cadastros");
    }
}

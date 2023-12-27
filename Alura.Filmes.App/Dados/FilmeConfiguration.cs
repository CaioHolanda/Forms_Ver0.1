
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System;

namespace Alura.Filmes.App.Dados
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder
            .ToTable("film");

            builder
                .Property(a => a.Id)
                .HasColumnName("film_id");

            builder
                .Property(a => a.Titulo)
                .HasColumnName("title")
                .HasColumnType("varchar(255)")
                .IsRequired();

            builder
                .Property(a => a.Descricao)
                .HasColumnName("description")
                .HasColumnType("text");

            builder
                .Property(a => a.Anolancamento)
                .HasColumnName("release_year")
                .HasColumnType("varchar(4)");

            builder
                .Property(a => a.Duracao)
                .HasColumnName("length");

            builder
                .Property<DateTime>("last_update")
                .HasColumnType("datetime");

            builder
                .Property<byte>("language_id");
            builder
                .Property<byte?>("original_language_id");
            builder
                .HasOne(f => f.IdiomaFalado)
                .WithMany(a => a.FilmesFalados)
                .HasForeignKey("language_id");
            builder
                .HasOne(fo => fo.IdiomaOriginal)
                .WithMany(i => i.FilmesOriginais)
                .HasForeignKey("original_language_id");

            builder
                .Property(f => f.TextoClassificacao)
                .HasColumnName("rating")
                .HasColumnType("varchar(10)");
            builder
                .Ignore(f => f.Classificacao);
        }
    }
}

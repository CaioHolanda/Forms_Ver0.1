
using Forms_Ver01.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using System;

namespace Forms_Ver01.App.Dados
{
    public class CodigosConfiguration : IEntityTypeConfiguration<Codigos>
    {
        public void Configure(EntityTypeBuilder<Codigos> builder)
        {
            builder
            .ToTable("Codigos");

            builder
                .Property(a => a.Id)
                .HasColumnName("id");

            builder
                .Property(a => a.Nome)
                .HasColumnName("Conta")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.Usuario)
                .HasColumnName("Usuario")
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder
                .Property(a => a.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("varchar(50)")
                .IsRequired(); 

            builder
                .Property<DateTime>("Ultima Alteracao")
                .HasColumnType("datetime");
        }
    }
}

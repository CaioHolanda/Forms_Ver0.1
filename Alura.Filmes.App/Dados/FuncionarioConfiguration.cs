using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class FuncionarioConfiguration : PessoaConfiguration<Funcionario>
    { 
        public override void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            base.Configure(builder);
            builder
                .ToTable("staff");
            builder
                .Property(x => x.Id)
                .HasColumnName("staff_id");
            builder
                .Property(p => p.Login)
                .HasColumnType("varchar(16)")
                .HasColumnName("username")
                .IsRequired();
            builder
                .Property(p => p.Senha)
                .HasColumnType("varchar(40)")
                .HasColumnName("password")
                .IsRequired();
        }
    }
}
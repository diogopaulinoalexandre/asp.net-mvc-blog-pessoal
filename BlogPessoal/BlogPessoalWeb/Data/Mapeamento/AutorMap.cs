using BlogPessoalWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoalWeb.Data.Mapeamento
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {
        public AutorMap()
        {
            ToTable("autor", "dbo");

            HasKey(t => t.Id);

            Property(X => X.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(X => X.Email).IsRequired().HasMaxLength(150).HasColumnName("email");
            Property(X => X.Senha).IsRequired().HasMaxLength(50).HasColumnName("senha");
            Property(X => X.Administrador).IsRequired().HasColumnName("administrador");
            Property(X => X.DataCadastro).IsRequired().HasColumnName("data_cadastro");
        }
    }
}
using BlogPessoalWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoalWeb.Data.Mapeamento
{
    public class CategoriaDeArtigoMap : EntityTypeConfiguration<CategoriaDeArtigo>
    {
        public CategoriaDeArtigoMap()
        {
            ToTable("categoria_artigo", "dbo");

            HasKey(t => t.Id);

            Property(X => X.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(X => X.Descricao).IsRequired().HasMaxLength(300).HasColumnName("descricao");

        }

    }
}
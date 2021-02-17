using BlogPessoalWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoalWeb.Data.Mapeamento
{
    public class ArtigoMap : EntityTypeConfiguration<Artigo>
    {
        public ArtigoMap()
        {
            ToTable("artigo", "dbo");

            HasKey(t => t.Id);

            Property(X => X.Titulo).IsRequired().HasMaxLength(300).HasColumnName("titulo");
            Property(X => X.CategoriaArtigoId).IsRequired().HasColumnName("categoria_artigo_id");
            Property(X => X.AutorId).IsRequired().HasColumnName("autor_id");
            Property(X => X.Conteudo).IsRequired().HasColumnName("conteudo");
            Property(X => X.Removido).IsRequired().HasColumnName("removido");
            Property(X => X.DataPublicacao).IsRequired().HasColumnName("data_publicacao");

        }

    }
}
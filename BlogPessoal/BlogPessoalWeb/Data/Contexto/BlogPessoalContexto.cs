using BlogPessoalWeb.Data.Mapeamento;
using BlogPessoalWeb.Models;
using System.Data.Entity;

namespace BlogPessoalWeb.Data.Contexto
{
    public class BlogPessoalContexto : DbContext
    {
        public BlogPessoalContexto()
            : base(typeof(BlogPessoalContexto).Name)
        {

        }

        public DbSet<CategoriaDeArtigo> CategoriasDeArtigo { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Artigo> Artigos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoriaDeArtigoMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new AutorMap());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ArtigoMap());
            base.OnModelCreating(modelBuilder);
        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogPessoalWeb.Models
{
    public class Artigo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Conteudo { get; set; }

        public DateTime DataPublicacao { get; set; }

        public int CategoriaArtigoId { get; set; }

        public int AutorId { get; set; }

        public bool Removido { get; set; }

        public virtual ICollection<CategoriaDeArtigo> CategoriaDeArtigo { get; set; }

        public virtual ICollection<Autor> Autor { get; set; }
    }
}
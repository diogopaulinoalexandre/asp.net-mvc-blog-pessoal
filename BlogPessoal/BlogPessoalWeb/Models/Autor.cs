using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogPessoalWeb.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome  { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^([\w\.\-]+)@([\W\-]+)((\.(\W){2,3})+)$",
            ErrorMessage ="o e-mail informado é inválido." )]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
       
        public Boolean  Administrador { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}
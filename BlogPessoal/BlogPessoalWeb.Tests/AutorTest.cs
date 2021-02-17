using BlogPessoalWeb.Data.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPessoalWeb.Tests
{
    [TestClass]
    class AutorTest
    {
        [TestMethod]
        public void consulta_autor_com_sucesso()
        {
            var ctx = new BlogPessoalContexto();
            var obj = ctx.Autores.FirstOrDefault();

            Assert.IsNotNull(obj);
        }
    }
}

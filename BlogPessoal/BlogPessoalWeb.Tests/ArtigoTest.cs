using BlogPessoalWeb.Data.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace BlogPessoalWeb.Tests
{
    [TestClass]
    public class ArtigoTest
    {
        [TestMethod]
        public void consulta_artigo_com_sucesso()
        {
            var ctx = new BlogPessoalContexto();
            var obj = ctx.Artigos.FirstOrDefault();

            Assert.IsNotNull(obj);

        }
    }

}

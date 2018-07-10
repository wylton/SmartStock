using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMvc.Domain.Entities;

namespace SmartMvc.Domain.Tests.Specifications
{
    [TestClass]
    public class MovimentScopesTests
    {
        private Box _validBox = new Box("Caixa", DateTime.Now);
        private Box _invalidBox = new Box("Caixa", "");
        private User _invalidEmailUser = new User("", "1234", "Separador", true);

        [TestMethod]
        public void TypeMovimentIsRequired()
        {

        }
    }
}

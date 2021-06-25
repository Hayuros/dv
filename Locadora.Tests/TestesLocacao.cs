using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExercicioCliente;

namespace Model
{
    namespace Locadora.Tests
    {
        [TestClass]
        public class TestesLocacao
        {
            [DataTestMethod]
            [DataRow("", "")]
            [DataRow(null, null)]
            [DataRow(" ", " ")]
            [DataRow("5", "500")]
            public void VerificaValorLocacao(string value, string value2) {
                    Locacao locacao = new Locacao();
                    var resultado = locacao.CalculoValorLocacao(Convert.ToInt32(value), Convert.ToInt32(value2));
                    Assert.IsFalse(resultado);
            }

            [DataTestMethod]
            [DataRow(" ", " ")]
            [DataRow(null, null)]
            [DataRow("25", "15")]
            public void VerificaDataDevolucao(string value, string value2) {
                Locacao locacao = new Locacao();
                var resultado = locacao.CalculoDataDevolucao(Convert.ToInt32(value), Convert.ToInt32(value2));
                Assert.IsFalse(resultado);
            }
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ExercicioCliente;

namespace Model{   
    namespace Locadora.Tests {
    [TestClass]
        public class TesteVeiculoLeve {
            [DataTestMethod]
            [DataRow("", "", "", "", "")]
            [DataRow(null)]
            [DataRow(" ", " ", " ", " ", " ")]
            [DataRow("Renault", "Scenic", 2007, 500, "Prata")]
            public void ModelVeiculoLeve(string Marca, string Modelo, int Ano, double Preco, string Cor) {
                VeiculoLeve veiculoLeve = new VeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
                var resultado = veiculoLeve.VerificaVeiculoLeve(Marca, Modelo, Ano, Preco, Cor);
                Assert.IsFalse(resultado);
            }
        }
    }
}
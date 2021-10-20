using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
namespace TestCalculadora
{
    [TestClass]
    public class TestCalculadora
    {
        [TestMethod]
        public void Add_RecibeNumerosSeparadosPorComa_DeberiaRetornarLaSuma()
        {
            //Arrange
            string numeros = "1,2";
            int expected = 3;

            //Act

            int actual = Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeUnSoloNumero_DeberiaRetornarLaSumaDelNumeroMasCero()
        {
            //Arrange
            string numeros = "2";
            int expected = 2;

            //Act

            int actual = Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeUnStringVacio_DeberiaRetornarUnCero()
        {
            //Arrange
            string numeros = string.Empty;
            int expected = 0;

            //Act

            int actual = Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_RecibeVariosNumerosSeparadosPorComa_DeberiaRetornarLaSumaDeTodos()
        {
            //Arrange
            string numeros = "2,2,1,2,3,1,3";
            int expected = 14;

            //Act

            int actual = Calculadora.Add(numeros);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

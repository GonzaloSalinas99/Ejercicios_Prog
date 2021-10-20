using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class Testeo
    {
        [TestMethod]
        public void ContarPalabras_CuandoRecibeDosPalabras_DeberiaRetornarNumeroDos()
        {
            //Arrange
            string texto = "Hola Mundo";
            int expected = 2;

            //Act
            int actual = texto.ContarPalabras();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FizzBuzz_CuandoRecibeUnNumeroMultipleDeTres_DeberiaRetornarFizz()
        {
            //Arrange
            int numero = 3;
            string expected = "Fizz";

            //Act 

            string resultado = numero.FizzBuzz();

            //Asseert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void FizzBuzz_CuandoRecibeUnNumeroMultipleDeTresyCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int numero = 15;
            string expected = "FizzBuzz";

            //Act 

            string resultado = numero.FizzBuzz();

            //Asseert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void FizzBuzz_CuandoRecibeUnNumeroMultipleDeCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int numero = 5;
            string expected = "Buzz";

            //Act 

            string resultado = numero.FizzBuzz();

            //Asseert
            Assert.AreEqual(expected, resultado);
        }
        [TestMethod]
        public void FizzBuzz_CuandoRecibeUnNumeroQueNoEsMultiploDeTresNiDeCinco_DeberiaRetornarElNumero()
        {
            //Arrange
            int numero = 2;
            string expected = "2";

            //Act 

            string resultado = numero.FizzBuzz();

            //Asseert
            Assert.AreEqual(expected, resultado);
        }

    }
}

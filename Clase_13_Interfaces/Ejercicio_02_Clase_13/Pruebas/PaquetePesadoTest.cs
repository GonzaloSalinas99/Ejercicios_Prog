using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Pruebas
{
    [TestClass]
    public class PaquetePesadoTest
    {
        [TestMethod]
        public void AplicarImpuesto_DeberiaRetornarCostoDeEnvioMasImpuestosAfipYAduana()
        {
            
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel25PorcientoSobreCostoEnvio_CuandoEsImplementacionExplicitaAfip()
        {

        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio_CuandoEsImplementacionImplicita()
        {

            //Arrange
            PaquetePesado paq = new PaquetePesado("1", 3M, "Villa Corina", "Lanus", 1323.23);
            decimal expected = 1.05M;

            //Act
            decimal actual = ((IAduana)paq).Impuestos;


            //Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarFalse()
        {
            //Arrange
            PaquetePesado paq = new PaquetePesado("1",23.21M,"Villa Corina","Lanus",1323.23);
            bool expected = false;

            //Act
            bool actual = paq.TienePrioridad;

            //Assert
            Assert.AreEqual(expected, actual);


        }


    }
}

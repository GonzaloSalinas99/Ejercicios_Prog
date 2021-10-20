using Biblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class PaqueteFragilTest
    {
        [TestMethod]
        public void AplicarImpuestos_deberiaRetornarCostoDeEnvioMasImpuestoAduana()
        {
            
        }

        [TestMethod]
        public void Impuestos_DeberiaRetornarValorImpuestoDel35PorcientoSobreCostoEnvio()
        {
            //Arrange 
            PaqueteFragil paq = new PaqueteFragil("1", 2M, "Lanus", "Pompeya", 10);
            decimal expected = 0.7M;

            //Act
            decimal actual = ((IAduana)paq).Impuestos;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TienePrioridad_DeberiaRetornarTrue()
        {
            //Arrange
            PaqueteFragil paq = new PaqueteFragil("1", 212.2M, "Lanus", "Pompeya", 10);
            bool expected = true;
            //Act
            bool actual = paq.TienePrioridad;

            //Assert

            Assert.AreEqual(expected, actual);

        }
    }
}

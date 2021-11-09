using Microsoft.VisualStudio.TestTools.UnitTesting;
using IO;
namespace Testeo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaExtensionJson_CuandoRecibeUnaExtensionJSon_DeberiaRetornarTrue()
        {
            //Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();
            bool expected = true;
            string extensionEsperada = ".json";

            //ACT
            bool actual = puntoJson.ValidarExtension(extensionEsperada);
            

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PruebaExtensionJson_CuandoRecibeUnaExtensionEquivocada_DeberiaRetornarExcepcion()
        {
            //Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();
            bool expected = true;
            string extensionEsperada = ".txt";

            //ACT
            bool actual = puntoJson.ValidarExtension(extensionEsperada);


            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

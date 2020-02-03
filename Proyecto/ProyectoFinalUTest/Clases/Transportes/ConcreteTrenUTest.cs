using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;

namespace ProyectoFinalUTest.Clases.Transportes
{
    [TestClass]
    public class ConcreteTrenUTest
    {
        ConcreteTren SUT = new ConcreteTren();

        [TestMethod]
        public void ObtenerCostoEnvio_DatosCorrectos_ValorCorrecto()
        {
            //Arrange
            double dMargenUtilidad = 40;
            double dDistancia = 446400;

            //act
            var Resultado  = SUT.ObtenerCostoEnvio(dMargenUtilidad, dDistancia);

            //Assert
            Assert.AreEqual(3124800, Resultado);
        }

        [TestMethod]
        public void ObtenerTiempoEntrega_DatosCorrectos_ValorCorrecto()
        {
            //Arrange
            double distancia = 1200;

            //act
            var Resultado = SUT.ObtenerTiempoEntrega(distancia);

            //assert
            Assert.AreEqual(15, Resultado);
        }
    }
}

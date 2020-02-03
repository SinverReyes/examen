using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;

namespace ProyectoFinalUTest.Clases.Transportes
{
    [TestClass]
    public class ConcreteBarcoUTest
    {
        ConcreteBarco SUT = new ConcreteBarco();

        [TestMethod]
        public void ObtenerCostoEnvio_DatosCorrectos_ValorCorrecto()
        {
            //Arrange
            double dMargenUtilidad = 40;
            double dDistancia = 100;

            //act
            var Resultado  = SUT.ObtenerCostoEnvio(dMargenUtilidad, dDistancia);

            //Assert
            Assert.AreEqual(140,Resultado);
        }

        [TestMethod]
        public void ObtenerTiempoEntrega_DatosCorrectos_ValorCorrecto()
        {
            //Arrange
            double distancia = 1200;

            //act
            int Resultado = (int)SUT.ObtenerTiempoEntrega(distancia);

            //assert
            Assert.AreEqual(26, Resultado);
        }
    }
}

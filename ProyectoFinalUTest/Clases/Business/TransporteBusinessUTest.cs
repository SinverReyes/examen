using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.Business
{
    [TestClass]
    public class TransporteBusinessUTest
    {
        [TestMethod]
        public void ValidarTransporte_TransporteInexistente_DevuelveNulo()
        {
            //arrenge
            TransporteBusiness SUT = new TransporteBusiness();

            //act
            var result = SUT.ObtenerTransporte("Patito");

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void ValidarTransporte_TransporteExistente_DevuelveInstancia()
        {
            //arrenge
            TransporteBusiness SUT = new TransporteBusiness();

            //act
            var result = SUT.ObtenerTransporte("Tren");

            //assert
            Assert.IsNotNull(result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.Business
{
    [TestClass]
    public class PaqueteriaBusinessUTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ElegirPaqueteria_PaqueteriaInexistente_DevuelveUnaException()
        {
            //arrenge
            PaqueteriaBusiness SUT = new PaqueteriaBusiness();

            //act
            var result = SUT.ElegirPaqueteria("Patito");

            //assert - se prueba que el erro producido sea de tipo exception
        }
    }
}

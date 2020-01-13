using System;
using Aplicacion_Eventos_3.Clases;
using Aplicacion_Eventos_3.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionEventos3UTest.Clases
{
    [TestClass]
    public class FechaBaseUTest
    {
        [TestMethod]
        public void ObtenerFechaBase_ObtenerFecha_FechaDiferenteHoy()
        {
            //ARRANGE
            string fecha = "21/10/2010 01:23:21 p. m.";
            var SUT = new FechaBase();

            //ACT
            DateTime resultado = SUT.ObtenerFechaBase(fecha);

            //ASSERT
            Assert.AreEqual(fecha, resultado.ToString());
        }

        [TestMethod]
        public void ObtenerFechaBase_ObtenerFecha_FechaHoy()
        {
            //ARRANGE
            string fecha = "13/01/2020";
            var SUT = new FechaBase();

            //ACT
            DateTime resultado = SUT.ObtenerFechaBase("");

            //ASSERT
            Assert.AreEqual(fecha, resultado.ToString("dd/MM/yyyy"));
        }
    }
}

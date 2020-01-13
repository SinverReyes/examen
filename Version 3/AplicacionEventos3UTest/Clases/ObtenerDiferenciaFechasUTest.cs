using System;
using Aplicacion_Eventos_3.Clases;
using Aplicacion_Eventos_3.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionEventos3UTest.Clases
{
    [TestClass]
    public class ObtenerDiferenciaFechasUTest
    {
        [TestMethod]
        public void ObtenerDiferenciaDias_ComparaFechas_ResultadoCorrecto()
        {
            ICompararDosFechas compararFechas = new CompararDosFechas();
            //Arrange
            DateTime FechaBase = DateTime.Parse("27/05/2015 5:50");
            DateTime FechaEvento = DateTime.Parse("29/05/2015 5:50");

            var SUT = new ObtenerDiferenciaFechas(compararFechas);

            //Act
            var resultado = SUT.ObtenerDiferenciaDias(FechaBase, FechaEvento);

            //Assert
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void ObtenerDiferenciaHoras_ComparaFechas_ResultadoCorrecto()
        {
            ICompararDosFechas compararFechas = new CompararDosFechas();
            //Arrange
            DateTime FechaBase = DateTime.Parse("29/05/2015 8:50");
            DateTime FechaEvento = DateTime.Parse("29/05/2015 5:50");

            var SUT = new ObtenerDiferenciaFechas(compararFechas);

            //Act
            var resultado = SUT.ObtenerDiferenciaHoras(FechaBase, FechaEvento);

            //Assert
            Assert.AreEqual(-3, resultado);
        }

        [TestMethod]
        public void ObtenerDiferenciaMinutos_ComparaFechas_ResultadoCorrecto()
        {
            ICompararDosFechas compararFechas = new CompararDosFechas();
            //Arrange
            DateTime FechaBase = DateTime.Parse("29/05/2015 5:10");
            DateTime FechaEvento = DateTime.Parse("29/05/2015 5:50");

            var SUT = new ObtenerDiferenciaFechas(compararFechas);

            //Act
            var resultado = SUT.ObtenerDiferenciaMinutos(FechaBase, FechaEvento);

            //Assert
            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void ObtenerDiferenciaMeses_ComparaFechas_ResultadoCorrecto()
        {
            ICompararDosFechas compararFechas = new CompararDosFechas();
            //Arrange
            DateTime FechaBase = DateTime.Parse("29/12/2015 5:50");
            DateTime FechaEvento = DateTime.Parse("29/05/2015 5:50");

            var SUT = new ObtenerDiferenciaFechas(compararFechas);

            //Act
            var resultado = SUT.ObtenerDiferenciaMes(FechaBase, FechaEvento);

            //Assert
            Assert.AreEqual(-7, resultado);
        }
    }
}

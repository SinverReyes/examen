using System;
using Aplicacion_Eventos_3.Clases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionEventos3UTest.Clases
{
    [TestClass]
    public class EventoOcurridoUTest
    {
        [TestMethod]
        public void MensajeEventoOcurrito_ObtenerMensajeCorrecto_ValoresPositivos()
        {
            //Arrange
            string ResultadoEsperado = "ocurrirá dentro de";
            var SUT = new EventoOcurrido();

            //Act
            var cResultado = SUT.MensajeEventoOcurrito(1);

            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }

        [TestMethod]
        public void MensajeEventoOcurrito_ObtenerMensajeCorrecto_ValoresNegativos()
        {
            //Arrange
            string ResultadoEsperado = "ocurrió hace";
            var SUT = new EventoOcurrido();

            //Act
            var cResultado = SUT.MensajeEventoOcurrito(-1);

            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }

        [TestMethod]
        public void MensajeEventoOcurrito_ObtenerMensajeCorrecto_ValorenCero()
        {
            //Arrange
            string ResultadoEsperado = "es justo ahora";
            var SUT = new EventoOcurrido();
            //Act
            var cResultado = SUT.MensajeEventoOcurrito(0);
            //Assert
            Assert.AreEqual(ResultadoEsperado, cResultado);
        }
    }
}

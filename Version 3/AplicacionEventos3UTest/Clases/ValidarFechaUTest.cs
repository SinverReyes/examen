using System;
using Aplicacion_Eventos_3.Clases;
using Aplicacion_Eventos_3.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AplicacionEventos3UTest.Clases
{
    [TestClass]
    public class ValidarFechaUTest
    {
        [TestMethod]
        public void ValidarFechaEvento_ValidarFecha_FechaIncorrecta()
        {
            IValidarFecha validarFecha = new ValidarFecha();

            var SUT = new ValidarFecha();

            var resultado = SUT.ValidarFechaEvento("24/12/2020");

            Assert.IsNotNull(resultado);

        }
    }
}

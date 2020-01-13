using System;
using FechaEventos.Clases;
using FechaEventos.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FechaEventosUTest.ClasesUTest
{
    [TestClass]
    public class ObtenerInfoArchivoTXTUTest
    {
        [TestMethod]
        public void ObtenerRutaArchivo_LecturaArchivo_TieneDatosCorrectos()
        {
            IImprimirSimple nuevoImprimir = new ImprimirSimple();

            //ARRANGE
            var ruta = @"C:\Users\sinver.reyes\Documents\GitHub\examen\FechaEventos\Eventos.txt";
            var SUT = new ObtenerInfoArchivoTXT(nuevoImprimir);

            //ACT
            var resultado = SUT.LeerArchivo(ruta);
            //Assert
            Assert.AreNotEqual(0, resultado.Count);
        }


    }
}

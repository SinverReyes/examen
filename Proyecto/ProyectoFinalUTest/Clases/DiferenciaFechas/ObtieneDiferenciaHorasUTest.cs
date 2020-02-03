using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.DiferenciaFechas
{

    [TestClass]
    public class ObtieneDiferenciaHorasUTest
    {
        static DateTime uno = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HoraPositiva()
        {
            //Arrange
            DateTime dos = uno.AddHours(1);
            ObtieneDiferenciaHoras SUT = new ObtieneDiferenciaHoras(dos, uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 hora", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HoraNegativa()
        {
            //Arrange
            DateTime dos = uno.AddHours(1);
            ObtieneDiferenciaHoras SUT = new ObtieneDiferenciaHoras(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 hora", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HorasNegativas()
        {
            //Arrange
            DateTime dos = uno.AddHours(10);
            ObtieneDiferenciaHoras SUT = new ObtieneDiferenciaHoras(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 horas", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaHoras_FechasCorrectas_HorasPotivas()
        {
            //Arrange
            DateTime dos = uno.AddHours(10);
            ObtieneDiferenciaHoras SUT = new ObtieneDiferenciaHoras(dos,uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 horas", cResultado);
        }
    }
}

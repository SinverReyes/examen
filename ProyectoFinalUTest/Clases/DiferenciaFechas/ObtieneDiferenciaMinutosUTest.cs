using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.DiferenciaFechas
{

    [TestClass]
    public class ObtieneDiferenciaMinutosUTest
    {
        static DateTime uno = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutoPositivo()
        {
            //Arrange
            DateTime dos = uno.AddMinutes(1);
            ObtieneDiferenciaMinutos SUT = new ObtieneDiferenciaMinutos(dos, uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 minuto", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutoNegativo()
        {
            //Arrange
            DateTime dos = uno.AddMinutes(1);
            ObtieneDiferenciaMinutos SUT = new ObtieneDiferenciaMinutos(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 minuto", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutosNegativos()
        {
            //Arrange
            DateTime dos = uno.AddMinutes(10);
            ObtieneDiferenciaMinutos SUT = new ObtieneDiferenciaMinutos(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 minutos", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMinutos_FechasCorrectas_MinutosPotivos()
        {
            //Arrange
            DateTime dos = uno.AddMinutes(10);
            ObtieneDiferenciaMinutos SUT = new ObtieneDiferenciaMinutos(dos,uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 minutos", cResultado);
        }
    }
}

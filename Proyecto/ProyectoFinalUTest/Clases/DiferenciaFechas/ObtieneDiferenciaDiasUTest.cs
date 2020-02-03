using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.DiferenciaFechas
{

    [TestClass]
    public class ObtieneDiferenciaDiasUTest
    {
        static DateTime uno = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiaPositivo()
        {
            //Arrange
            DateTime dos = uno.AddDays(1);
            ObtieneDiferenciaDias SUT = new ObtieneDiferenciaDias(dos, uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 día", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiaNegativo()
        {
            //Arrange
            DateTime dos = uno.AddDays(1);
            ObtieneDiferenciaDias SUT = new ObtieneDiferenciaDias(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 día", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiasNegativos()
        {
            //Arrange
            DateTime dos = uno.AddDays(10);
            ObtieneDiferenciaDias SUT = new ObtieneDiferenciaDias(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,10 días", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaDias_FechasCorrectas_DiasPotivos()
        {
            //Arrange
            DateTime dos = uno.AddDays(10);
            ObtieneDiferenciaDias SUT = new ObtieneDiferenciaDias(dos,uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,10 días", cResultado);
        }
    }
}

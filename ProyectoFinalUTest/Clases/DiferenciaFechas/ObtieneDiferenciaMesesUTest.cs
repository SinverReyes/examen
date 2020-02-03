using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoFinal;
using System;

namespace ProyectoFinalUTest.Clases.DiferenciaFechas
{

    [TestClass]
    public class ObtieneDiferenciaMesesUTest
    {
        static DateTime uno = DateTime.Now;

        [TestMethod]
        public void ObtieneDiferenciaMeses_FechasCorrectas_MesPositivo()
        {
            //Arrange
            DateTime dos = uno.AddDays(50);
            ObtieneDiferenciaMeses SUT = new ObtieneDiferenciaMeses(dos, uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,1 mes", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMeses_FechasCorrectas_MesNegativo()
        {
            //Arrange
            DateTime dos = uno.AddDays(50);
            ObtieneDiferenciaMeses SUT = new ObtieneDiferenciaMeses(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,1 mes", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMeses_FechasCorrectas_MesesNegativos()
        {
            //Arrange
            DateTime dos = uno.AddDays(60);
            ObtieneDiferenciaMeses SUT = new ObtieneDiferenciaMeses(uno, dos);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("-,2 meses", cResultado);
        }

        [TestMethod]
        public void ObtieneDiferenciaMeses_FechasCorrectas_MesesPotivos()
        {
            //Arrange
            DateTime dos = uno.AddDays(60);
            ObtieneDiferenciaMeses SUT = new ObtieneDiferenciaMeses(dos,uno);

            //ACT
            var cResultado = SUT.ObtenerDiferenciaFechas();

            //Asert 
            Assert.AreEqual("+,2 meses", cResultado);
        }
    }
}

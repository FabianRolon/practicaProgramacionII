using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInstanciaList()
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            Assert.IsNotNull(competencia.Competidores);
        }
        [TestMethod]
        [ExpectedException(typeof(CompetenciaNoDisponibleException))]
        public void TestCompetenciaNoDisponible()
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            AutoF1 autoF1 = new AutoF1(44, "Ferrari");
            bool pudo = competencia + autoF1;
        }
        [TestMethod]
        public void TestCompetenciaMotoCross()
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            Assert.IsTrue(competencia + motoCross);
        }
        [TestMethod]
        public void TestEstaONoEsta()
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            Assert.IsTrue(competencia + motoCross);
            Assert.IsTrue(competencia == motoCross);
        }
        [TestMethod]
        public void TestQuitarVehiculo()
        {
            Competencia competencia = new Competencia(2, 40, Competencia.TipoCompetencia.MotoCross);
            MotoCross motoCross = new MotoCross(44, "KTM");
            bool pudo = competencia + motoCross;
            Assert.IsTrue(competencia - motoCross);
            Assert.IsTrue(competencia != motoCross);
        }
    }
}

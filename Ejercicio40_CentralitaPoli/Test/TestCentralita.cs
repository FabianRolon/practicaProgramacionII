using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio40_CentralitaPoli;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestCentralita
    {
        [TestMethod]
        public void TestListaLlamadas()
        {
            //arrange
            Centralita centralita = new Centralita("Test");
            List<Llamada> testListaLLamada;
            //act
            testListaLLamada = centralita.Llamadas;
            //assert
            Assert.IsNotNull(testListaLLamada);
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestLocalCentralitaException()
        {
            //arrange
            Centralita centralita = new Centralita("Test");
            Local local = new Local("1234", 10, "4321", 50);
            Local localRepe = new Local("1234", 20, "4321", 60);
            //act
            centralita += local;
            centralita += localRepe;
            //assert
        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void TestProvincialCentralitaException()
        {
            //arrange
            Centralita centralita = new Centralita("Test");
            Provincial provincial = new Provincial("1234", Provincial.Franja.Franja_1, 10, "4321");
            Provincial provincialRepe = new Provincial("1234", Provincial.Franja.Franja_2, 20, "4321");
            //act
            centralita += provincial;
            centralita += provincialRepe;
            //assert
        }
        [TestMethod]
        public void TestIgualdadtipoLLamadas()
        {
            //arrange
            Local local = new Local("1234", 10, "4321", 50);
            Local localRepe = new Local("1234", 20, "4321", 60);
            Provincial provincial = new Provincial("1234", Provincial.Franja.Franja_1, 10, "4321");
            Provincial provincialRepe = new Provincial("1234", Provincial.Franja.Franja_2, 20, "4321");
            //act
            //assert
            Assert.AreEqual(local, localRepe);
            Assert.AreNotEqual(local, provincial);
            Assert.AreNotEqual(local, provincialRepe);
            Assert.AreEqual(provincial, provincialRepe);
        }
    }
}

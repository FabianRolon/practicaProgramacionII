using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio42;

namespace Test
{
    [TestClass]
    public class TestEj45
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionPorCero()
        {
            MiClase miClase;
            miClase = new MiClase();
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMiMetodo()
        {
            MiClase.MetodoDivision();
        }
        [TestMethod]
        [ExpectedException(typeof(UnaExepcion))]
        public void TestMiClaseConParametro()
        {
            MiClase clase = new MiClase(1);
        }
        [TestMethod]
        [ExpectedException(typeof(MiExcepcion))]
        public void TestMetodoDeInstancia()
        {
            OtraClase clase = new OtraClase();
            clase.UnMetodoDeInstancia();
        }

    }
}

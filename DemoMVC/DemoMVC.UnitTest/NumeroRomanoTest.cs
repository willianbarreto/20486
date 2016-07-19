using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DemoMVC.UnitTest
{
    public class NumeroRomano
    {
        private string _numeroRomano;
        public NumeroRomano(string numeroRomano)
        {
            _numeroRomano = numeroRomano;
        }

        private Dictionary<string, int> _mapa =new 
            Dictionary<string, int>() { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 } };

        public int Conversor()
        {
            return _mapa[_numeroRomano];
        }
    }

    [TestClass]
    public class NumeroRomanoTest
    {
        [TestMethod]
        public void DadoQueONumeroRomanoE_I()
        {
            var nr = new NumeroRomano("I");
            var valorEsperado = 1;

            Assert.AreEqual(valorEsperado, nr.Conversor());
        }

        [TestMethod]
        public void DadoQueONumeroRomanoE_V()
        {
            var nr = new NumeroRomano("V");
            var valorEsperado = 5;

            Assert.AreEqual(valorEsperado, nr.Conversor());
        }

        [TestMethod]
        public void DadoQueONumeroRomanoE_X()
        {
            var nr = new NumeroRomano("X");
            var valorEsperado = 10;

            Assert.AreEqual(valorEsperado, nr.Conversor());
        }

        [TestMethod]
        public void DadoQueONumeroRomanoE_L()
        {
            var nr = new NumeroRomano("L");
            var valorEsperado = 50;

            Assert.AreEqual(valorEsperado, nr.Conversor());
        }
    }
}

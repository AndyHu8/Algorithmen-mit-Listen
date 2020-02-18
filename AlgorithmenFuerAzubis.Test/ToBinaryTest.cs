using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class ToBinaryTest
    {
        [TestMethod]
        public void ToBinary_Test()
        {
            var sut = new ToBinary();
            var ToBinary_Ergebnis = sut.ToBinary_Funktion(2);

            Assert.AreEqual(ToBinary_Ergebnis[0], 1);
            Assert.AreEqual(ToBinary_Ergebnis[1], 0);

        }
    }
}

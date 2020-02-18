using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class TachometerIncTest
    {
        [TestMethod]
        public void TachometerInc_Test()
        {
            var sut = new TachometerInc();
            var TachometerInc_Ergebnis = sut.TachometerInc_Funktion(new int[] { 4, 0, 7 });

            Assert.AreEqual(TachometerInc_Ergebnis[0], 4);
            Assert.AreEqual(TachometerInc_Ergebnis[1], 0);
            Assert.AreEqual(TachometerInc_Ergebnis[2], 8);
            
            Assert.AreEqual(TachometerInc_Ergebnis.Length, 3);

        }
    }
}

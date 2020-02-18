using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class normalizeTest
    {
        [TestMethod]
        public void normalize_Test()
        {
            var sut = new normalize();
            var normalize_Ergebnis = sut.normalize_Funktion(new int[] { 5, 8, 12, 24, 11, 10, 9 }, 10);

            Assert.AreEqual(normalize_Ergebnis[0], 5);
            Assert.AreEqual(normalize_Ergebnis[1], 8);
            Assert.AreEqual(normalize_Ergebnis[2], 11);
            Assert.AreEqual(normalize_Ergebnis[3], 17);
            Assert.AreEqual(normalize_Ergebnis[4], 10);
            Assert.AreEqual(normalize_Ergebnis[5], 10);
            Assert.AreEqual(normalize_Ergebnis[6], 9);

            Assert.AreEqual(normalize_Ergebnis.Length, 7);

        }
    }
}

using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class InsertAtTest
    {
        [TestMethod]
        public void InsertAt_Test()
        {
            var sut = new insertat();
            var InsertAt_Ergebnis = sut.InsertAt_Funktion(new int[] { 2, 3, 4, 6, 7 }, 5, 3);

            Assert.AreEqual(InsertAt_Ergebnis[0], 2);
            Assert.AreEqual(InsertAt_Ergebnis[1], 3);
            Assert.AreEqual(InsertAt_Ergebnis[2], 4);
            Assert.AreEqual(InsertAt_Ergebnis[3], 5);
            Assert.AreEqual(InsertAt_Ergebnis[4], 6);
            Assert.AreEqual(InsertAt_Ergebnis[5], 7);
            Assert.AreEqual(InsertAt_Ergebnis.Length, 6);
        }
    }
}

using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class RemoveAtTest
    {
        [TestMethod]
        public void RemoveAt_Test()
        {
            var sut = new RemoveAt();
            var RemoveAt_Ergebnis = sut.RemoveAt_Funktion(new int[] { 1, 2, 3, 4, 5, 6 }, 3);

            Assert.AreEqual(RemoveAt_Ergebnis[0], 1);
            Assert.AreEqual(RemoveAt_Ergebnis[1], 2);
            Assert.AreEqual(RemoveAt_Ergebnis[2], 3);
            Assert.AreEqual(RemoveAt_Ergebnis[3], 5);
            Assert.AreEqual(RemoveAt_Ergebnis[4], 6);
            
            Assert.AreEqual(RemoveAt_Ergebnis.Length, 5);
        }
    }
}

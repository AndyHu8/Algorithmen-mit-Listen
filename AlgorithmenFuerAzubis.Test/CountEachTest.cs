using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class CountEachTest
    {
        [TestMethod]
        public void CountEach_Test()
        {
            var sut = new CountEach();
            var CountEach_Ergebnis = sut.CountEach_Funktion(new int[] { 4, 4, 0, 7, 4 });

            Assert.AreEqual(CountEach_Ergebnis[0], 4);
            Assert.AreEqual(CountEach_Ergebnis[1], 3);
            Assert.AreEqual(CountEach_Ergebnis[2], 0);
            Assert.AreEqual(CountEach_Ergebnis[3], 1);
            Assert.AreEqual(CountEach_Ergebnis[4], 7);
            Assert.AreEqual(CountEach_Ergebnis[5], 1);


            Assert.AreEqual(CountEach_Ergebnis.Length, 6);
        }

    }
}

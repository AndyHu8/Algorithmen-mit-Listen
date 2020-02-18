using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void Sort_Test()
        {
            var sut = new Sort();
            var Sort_Ergebnis = sut.Sort_Funktion(new int[] { 1, 9, 6, 7, 5, 9 });

            Assert.AreEqual(Sort_Ergebnis[0], 9);
            Assert.AreEqual(Sort_Ergebnis[1], 9);
            Assert.AreEqual(Sort_Ergebnis[2], 7);
            Assert.AreEqual(Sort_Ergebnis[3], 6);
            Assert.AreEqual(Sort_Ergebnis[4], 5);
            Assert.AreEqual(Sort_Ergebnis[5], 1);

            Assert.AreEqual(Sort_Ergebnis.Length, 6);
        }
    }

    [TestClass]
    public class SortTest2
    {
        [TestMethod]
        public void Sort_Test()
        {
            var sut = new Sort();
            var Sort_Ergebnis = sut.Sort_Funktion(new int[] { 3, 4, 4, 1, 8, 2 });

            Assert.AreEqual(Sort_Ergebnis[0], 8);
            Assert.AreEqual(Sort_Ergebnis[1], 4);
            Assert.AreEqual(Sort_Ergebnis[2], 4);
            Assert.AreEqual(Sort_Ergebnis[3], 3);
            Assert.AreEqual(Sort_Ergebnis[4], 2);
            Assert.AreEqual(Sort_Ergebnis[5], 1);

            Assert.AreEqual(Sort_Ergebnis.Length, 6);
        }
    }
}

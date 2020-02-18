using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class TachometerAddTest
    {
        [TestMethod]
        public void TachometerAdd_Test()
        {
            var sut = new TachometerAdd();
            var TachometerAdd_Ergebnis = sut.TachometerAdd_Funktion(new int[] { 4, 0, 7 }, new int[] { 8, 6, 2});

            Assert.AreEqual(TachometerAdd_Ergebnis[0], 1);
            Assert.AreEqual(TachometerAdd_Ergebnis[1], 2);
            Assert.AreEqual(TachometerAdd_Ergebnis[2], 6);
            Assert.AreEqual(TachometerAdd_Ergebnis[3], 9);


            Assert.AreEqual(TachometerAdd_Ergebnis.Length, 4);
        }

        [TestMethod]
        public void TachometerAdd_Test2()
        {
            var sut = new TachometerAdd();
            var TachometerAdd_Ergebnis = sut.TachometerAdd_Funktion(new int[] { 4, 0, 7 }, new int[] {  6, 2 });

            Assert.AreEqual(TachometerAdd_Ergebnis[0], 4);
            Assert.AreEqual(TachometerAdd_Ergebnis[1], 6);
            Assert.AreEqual(TachometerAdd_Ergebnis[2], 9);


            Assert.AreEqual(TachometerAdd_Ergebnis.Length, 3);
        }

        [TestMethod]
        public void TachometerAdd_Test3()
        {
            var sut = new TachometerAdd();
            var TachometerAdd_Ergebnis = sut.TachometerAdd_Funktion(new int[] { 9,9,9,9 }, new int[] { 2,2,2,2 });

            Assert.AreEqual(TachometerAdd_Ergebnis[0], 1);
            Assert.AreEqual(TachometerAdd_Ergebnis[1], 2);
            Assert.AreEqual(TachometerAdd_Ergebnis[2], 2);
            Assert.AreEqual(TachometerAdd_Ergebnis[3], 2);
            Assert.AreEqual(TachometerAdd_Ergebnis[4], 1);

            Assert.AreEqual(TachometerAdd_Ergebnis.Length, 5);
        }
    }
}

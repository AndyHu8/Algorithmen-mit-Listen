using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class SplitAtTest
    {
        [TestMethod]
        public void SplitAt_Test()
        {
            var sut = new SplitAt();
            var (SplitAt_Ergebnis, SplitAt_Ergebnis2) = sut.SplitAt_Funktion(new int[] { 1, 2, 3, 4, 5, 6 }, 2);
            

            Assert.AreEqual(SplitAt_Ergebnis[0], 1);
            Assert.AreEqual(SplitAt_Ergebnis[1], 2);
            Assert.AreEqual(SplitAt_Ergebnis[2], 3);

            Assert.AreEqual(SplitAt_Ergebnis2[0], 4);
            Assert.AreEqual(SplitAt_Ergebnis2[1], 5);
            Assert.AreEqual(SplitAt_Ergebnis2[2], 6);

            Assert.AreEqual(SplitAt_Ergebnis.Length, 3);
            Assert.AreEqual(SplitAt_Ergebnis2.Length, 3);


        }
        [TestMethod]
        public void Einfaches_Array()
        {
            var sut = new SplitAt();
            var (result1, result2) = sut.SplitAt_Funktion(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4);
            Assert.AreEqual(result1[0], 1);
            Assert.AreEqual(result1[1], 2);
            Assert.AreEqual(result1[2], 3);
            Assert.AreEqual(result1[3], 4);
            Assert.AreEqual(result1[4], 5);
            Assert.AreEqual(result2[0], 6);
            Assert.AreEqual(result2[1], 7);
            Assert.AreEqual(result2[2], 8);
        }
        [TestMethod]
        public void In_der_Mitte_halbiert()
        {
            var sut = new SplitAt();
            var (result1, result2) = sut.SplitAt_Funktion(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3);
            Assert.AreEqual(result1[0], 1);
            Assert.AreEqual(result1[1], 2);
            Assert.AreEqual(result1[2], 3);
            Assert.AreEqual(result1[3], 4);
            Assert.AreEqual(result2[0], 5);
            Assert.AreEqual(result2[1], 6);
            Assert.AreEqual(result2[2], 7);
            Assert.AreEqual(result2[3], 8);
        }
        [TestMethod]
        public void Erstes_Array_laenger()
        {
            var sut = new SplitAt();
            var (result1, result2) = sut.SplitAt_Funktion(new int[] { 1, 2, 3, 3, 1, 3 }, 4);
            Assert.AreEqual(result1[0], 1);
            Assert.AreEqual(result1[1], 2);
            Assert.AreEqual(result1[2], 3);
            Assert.AreEqual(result1[3], 3);
            Assert.AreEqual(result1[4], 1);
            Assert.AreEqual(result2[0], 3);
        }
        [TestMethod]
        public void Zweites_Array_laenger()
        {
            var sut = new SplitAt();
            var (result1, result2) = sut.SplitAt_Funktion(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 2);
            Assert.AreEqual(result1[0], 1);
            Assert.AreEqual(result1[1], 2);
            Assert.AreEqual(result1[2], 3);
            Assert.AreEqual(result2[0], 4);
            Assert.AreEqual(result2[1], 5);
            Assert.AreEqual(result2[2], 6);
            Assert.AreEqual(result2[3], 7);
            Assert.AreEqual(result2[4], 8);
        }
    }
}

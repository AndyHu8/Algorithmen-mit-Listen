using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class AddEachTest
    {
        [TestMethod]
        public void AddEach_Gleicher_Länge_Test()
        {
            var sut = new AddEach();
            var AddEach_Ergebnis = sut.AddEach_Funktion(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 });

            Assert.AreEqual(AddEach_Ergebnis[0], 2);
            Assert.AreEqual(AddEach_Ergebnis[1], 4);
            Assert.AreEqual(AddEach_Ergebnis[2], 6);
            Assert.AreEqual(AddEach_Ergebnis[3], 8);
            Assert.AreEqual(AddEach_Ergebnis[4], 10);
            Assert.AreEqual(AddEach_Ergebnis[5], 12);

            Assert.AreEqual(AddEach_Ergebnis.Length, 6);
            
        }

        [TestMethod]
        public void AddEach_Erstes_Array_Länger_Test()
        {
            var sut = new AddEach();
            var AddEach_Ergebnis = sut.AddEach_Funktion(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 2, 3 });

            Assert.AreEqual(AddEach_Ergebnis[0], 2);
            Assert.AreEqual(AddEach_Ergebnis[1], 4);
            Assert.AreEqual(AddEach_Ergebnis[2], 6);
            Assert.AreEqual(AddEach_Ergebnis[3], 4);
            Assert.AreEqual(AddEach_Ergebnis[4], 5);
            Assert.AreEqual(AddEach_Ergebnis[5], 6);

            Assert.AreEqual(AddEach_Ergebnis.Length, 6);

        }

        [TestMethod]
        public void AddEach_Zweites_Array_Länger_Test()
        {
            var sut = new AddEach();
            var AddEach_Ergebnis = sut.AddEach_Funktion(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4, 5, 6 });

            Assert.AreEqual(AddEach_Ergebnis[0], 2);
            Assert.AreEqual(AddEach_Ergebnis[1], 4);
            Assert.AreEqual(AddEach_Ergebnis[2], 6);
            Assert.AreEqual(AddEach_Ergebnis[3], 4);
            Assert.AreEqual(AddEach_Ergebnis[4], 5);
            Assert.AreEqual(AddEach_Ergebnis[5], 6);

            Assert.AreEqual(AddEach_Ergebnis.Length, 6);

        }
    }
}

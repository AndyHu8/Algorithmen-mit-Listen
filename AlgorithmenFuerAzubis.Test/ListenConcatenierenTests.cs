using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class ListenConcatenierenTests
    {
        [TestMethod]
        public void Zwei_leere_Listen_ergeben_leere_Liste()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { }, new int[] { });

            Assert.AreEqual(result.Length, 0);
        }

        [TestMethod]
        public void Erste_Liste_leer_ergibt_zweite_Liste()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { }, new int[] { 4, 8});

            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result[0], 4);
            Assert.AreEqual(result[1], 8);
        }

        [TestMethod]
        public void Zweite_Liste_leer_ergibt_erste_Liste()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { 4, 8 }, new int[] { });

            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result[0], 4);
            Assert.AreEqual(result[1], 8);
        }

        [TestMethod]
        public void Zwei_identische_kurze_listen_ergeben_eine()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { 0 }, new int[] { 0 });

            Assert.AreEqual(result.Length, 2);
            Assert.AreEqual(result[0], 0);
            Assert.AreEqual(result[1], 0);
        }

        [TestMethod]
        public void Zwei_Listen_ergebnen_eine_Vollständige()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { 1, 2 }, new int[] { 3, 4 });

            Assert.AreEqual(result.Length, 4);
            Assert.AreEqual(result[0], 1);
            Assert.AreEqual(result[3], 4);
        }

        [TestMethod]
        public void Zwei_identische_Listen_ergebnen_eine_Vollständige()
        {
            var sut = new ListenConcatenieren();
            var result = sut.Concatenate(new int[] { 3, 4 }, new int[] { 3, 4 });

            Assert.AreEqual(result.Length, 4);
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[3], 4);
        }
    }
}

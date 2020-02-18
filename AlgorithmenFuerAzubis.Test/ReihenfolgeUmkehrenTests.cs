using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class ReihenfolgeUmkehrenTests
    {
        [TestMethod]
        public void Riehenfolge_ist_gleich_weil_nur_ein_element_in_der_Liste_ist()
        {
            var sut = new ReihenfolgeUmkehren();
            var result = sut.Execute(new[] { 7 });

            Assert.AreEqual(result.Length, 1);
            Assert.AreEqual(result[0], 7);
        }

        [TestMethod]
        public void Reihenfolge_ist_gleich_weil_die_Liste_ein_Palindrom_ist()
        {
            var sut = new ReihenfolgeUmkehren();
            var result = sut.Execute(new[] { 5, 6, 5 });

            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual(result[0], 5);
            Assert.AreEqual(result[1], 6);
            Assert.AreEqual(result[2], 5);
        }

        [TestMethod]
        public void Reihenfolge_wird_umgekehrt()
        {
            var sut = new ReihenfolgeUmkehren();
            var result = sut.Execute(new[] { 7, 8, 9 });

            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual(result[0], 9);
            Assert.AreEqual(result[1], 8);
            Assert.AreEqual(result[2], 7);
        }

        [TestMethod]
        public void Doppelt_angewendet_bleibt_die_liste_gleich()
        {
            var sut = new ReihenfolgeUmkehren();
            var result = sut.Execute(sut.Execute(new[] { 7, 8, 9 }));

            Assert.AreEqual(result.Length, 3);
            Assert.AreEqual(result[0], 7);
            Assert.AreEqual(result[1], 8);
            Assert.AreEqual(result[2], 9);
        }
    }
}

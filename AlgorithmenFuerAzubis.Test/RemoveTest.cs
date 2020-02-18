using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_Test()
        {
            var sut = new Remove();
            var Remove_Ergebnis = sut.Remove_Funktion(new int[] { 1, 2, 3, 3, 4, 3}, 3);

            Assert.AreEqual(Remove_Ergebnis[0], 1);
            Assert.AreEqual(Remove_Ergebnis[1], 2);
            Assert.AreEqual(Remove_Ergebnis[2], 4);

            Assert.AreEqual(Remove_Ergebnis.Length, 3);
        }
    }
}

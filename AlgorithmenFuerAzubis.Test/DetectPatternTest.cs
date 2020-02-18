using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class DetectPatternTest
    {
        [TestMethod]
        public void DetectPattern_Test()
        {
            var sut = new DetectPattern();
            var DetectPattern_Ergebnis = sut.DetectPattern_Funktion(new int[] { 5, 6, 4 }, 
            new int[] { 1, 8, 5, 6, 5, 6, 4, 7, 9, 5, 6, 4});

            Assert.AreEqual(DetectPattern_Ergebnis, 7);
        }
    }
}

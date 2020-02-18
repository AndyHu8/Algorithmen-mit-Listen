using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class PrependTest
    {
        [TestMethod]
        public void Prepend_Test()
        {
            var sut = new Prepend();
            var Result = sut.Funktion(new int[] { 2, 3, 4, 5, 6 }, 1);

            Assert.AreEqual(Result[1], 2);
            Assert.AreEqual(Result[2], 3);
            Assert.AreEqual(Result[3], 4);
            Assert.AreEqual(Result[4], 5);
            Assert.AreEqual(Result[5], 6);
            Assert.AreEqual(Result[0], 1);
            Assert.AreEqual(Result.Length, 6);
        }
    }
}

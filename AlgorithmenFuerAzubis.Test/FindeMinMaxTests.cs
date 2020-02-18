using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class FindeMinMaxTests
    {
        [TestMethod]
        public void Min_und_max_sind_identisch()
        {
            var sut = new FindeMinMax();
            var (Minimum, Maximum) = sut.Execute(new[] { 0,0 });

            Assert.AreEqual(Minimum, 0); 
            Assert.AreEqual(Maximum, 0);
        }

        [TestMethod]
        public void Min_und_max_sind_gleich()
        {
            var sut = new FindeMinMax();
            var (min, max) = sut.Execute(new[] { 0 });

            Assert.AreEqual(min, 0);
            Assert.AreEqual(max, 0);
        }

        [TestMethod]
        public void Min_und_max_sind_negativ()
        {
            var sut = new FindeMinMax();
            var (min, max) = sut.Execute(new[] { -7, -8 });

            Assert.AreEqual(min, -8);
            Assert.AreEqual(max, -7);
        }

        [TestMethod]
        public void Min_und_max_sind_in_langer_liste()
        {
            var sut = new FindeMinMax();
            var (min, max) = sut.Execute(new[] { 5, 1, 10, 7, 7, 2, 9 });

            Assert.AreEqual(min, 1);
            Assert.AreEqual(max, 10);
        }
    }
}

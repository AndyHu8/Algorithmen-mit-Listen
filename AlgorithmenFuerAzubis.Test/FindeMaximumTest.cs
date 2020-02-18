using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class FindeMaximumTest
    {
        [TestMethod]
        public void Einfaches_Array()
        {
            var sut = new FindeMaximum();
            var maximum = sut.Execute(new[] { 1, 2, 3, 4, 5 });

            Assert.AreEqual(maximum, 5);
        }
        [TestMethod]
        public void Ein_Wert_Im_Array()
        {
            var sut = new FindeMaximum();
            var maximum = sut.Execute(new[] {7});

            Assert.AreEqual(maximum, 7);
        }

        [TestMethod]
        public void Umgedrehtes_Array()
        {
            var sut = new FindeMaximum();
            var maximum = sut.Execute(new[] { 5,4,3,2,1 });

            Assert.AreEqual(maximum, 5);
        }

        [TestMethod]
        public void Gleiche_Zahlen_Im_Array()
        {
            var sut = new FindeMaximum();
            var maximum = sut.Execute(new[] { 8,8,8 });

            Assert.AreEqual(maximum, 8);
        }

        [TestMethod]
        public void Array_Mit_Negativen_Zahlen()
        {
            var sut = new FindeMaximum();
            var maximum = sut.Execute(new[] { -5,-4,-3,-2,-1 });

            Assert.AreEqual(maximum, -1);
        }
    }
}
    
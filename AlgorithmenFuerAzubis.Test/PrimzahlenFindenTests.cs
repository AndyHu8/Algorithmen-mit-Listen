using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class PrimzahlenFindenTests
    {
        [TestMethod]
        public void Leere_Liste_hat_keine_Primzahlen()
        {
            {
                var sut = new Prime2();
                var result = sut.Execute(new int[] { });

                Assert.AreEqual(result.Length, 0);
            }
        }

        [TestMethod]
        public void Liste_ohne_Primzahlen_hat_keine_Primzahlen()
        {
            {
                var sut = new PrimzahlenFinden();
                var result = sut.Execute(new int[] { 4, 6, 9, 12, 15 });

                Assert.AreEqual(result.Length, 0);
            }
        }

        [TestMethod]
        public void Liste_mit_Primzahlen_findet_nur_Primzahlen()
        {
            {
                var sut = new PrimzahlenFinden();
                var result = sut.Execute(new int[] { 1, 2, 3, 5, 7, 11, 13 });

                Assert.AreEqual(result.Length, 6);
                Assert.AreEqual(result[0], 2);
                Assert.AreEqual(result[1], 3);
                Assert.AreEqual(result[2], 5);
                Assert.AreEqual(result[3], 7);
                Assert.AreEqual(result[4], 11);
                Assert.AreEqual(result[5], 13);
            }
        }

        [TestMethod]
        public void Liste_mit_negativen_Zahlen_findet_nur_positive_Primzahlen()
        {
            {
                var sut = new Prime2();
                var result = sut.Execute(new int[] { -4, -3, -2, -1, 0, 1, 2, 3, 4 });

                Assert.AreEqual(result.Length, 2);
                Assert.AreEqual(result[0], 2);
                Assert.AreEqual(result[1], 3);
                
            }
        }
    }
}

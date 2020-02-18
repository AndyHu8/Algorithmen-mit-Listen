using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class GetTailTests
    {
        [TestMethod]
        public void Tail_der_Liste_korrekt_erhalten()
        {
            var getTail = new GetTail();
            var tail = getTail.Execute(new[] { 3, 4, 5, });

            Assert.AreEqual(tail.Length, 2);
            Assert.AreEqual(tail[0], 4);
            Assert.AreEqual(tail[1], 5);
        }

        [TestMethod]
        public void Tail_ist_leer_wenn_liste_1_element_hat()
        {
            var getTail = new GetTail();
            var tail = getTail.Execute(new[] { 3 });

            Assert.AreEqual(tail.Length, 0);
        }
    }
}

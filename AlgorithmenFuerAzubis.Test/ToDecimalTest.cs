using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class ToDecimalTest
    {
        [TestMethod]
        public void ToDecimal_Test()
        {
            var sut = new ToDecimal();
            var ToDecimal_Ergebnis = sut.ToDecimal_Funktion(new int[] { 1, 1 });

            Assert.AreEqual(ToDecimal_Ergebnis, 3);
            
            

        }
    }
}

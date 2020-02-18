using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class AppendTests
    {       
            [TestMethod]
            public void Append_Test()
            {
                var sut = new Append();
                var result = sut.Execute(new int[] {1,2,3,4,5 }, 9);

                Assert.AreEqual(result[0], 1);
                Assert.AreEqual(result[1], 2);
                Assert.AreEqual(result[2], 3);
                Assert.AreEqual(result[3], 4);
                Assert.AreEqual(result[4], 5);
                Assert.AreEqual(result[5], 9);
                Assert.AreEqual(result.Length, 6);


            }
        
    }
}


using AlgorithmenFuerAzubis.Arrays;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmenFuerAzubis.Test
{
    [TestClass]
    public class GetHeadTests
    {
        [TestMethod]
        public void Kopf_ist_erstes_Element()
        {
            var getHead = new GetHead();
            var head = getHead.Execute(new[] { 5, 6, 7 });
            Assert.AreEqual(head, 5);
        }

        [TestMethod]
        public void Kopf_ist_negativ()
        {
            var getHead = new GetHead();
            var head = getHead.Execute(new[] { -5 });
            Assert.AreEqual(head, -5);
        }

        [TestMethod]
        public void Kopf_ist_immer_gleich()
        {
            var getHead = new GetHead();
            var head = getHead.Execute(new[] { 7,7,7 });
            Assert.AreEqual(head, 7);
        }
    }
}

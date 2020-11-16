using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Heap;

namespace test
{
    [TestClass]
    public class HeapTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var testHeap = new HeapClass();
            Assert.AreEqual(testHeap.counter, 666);
        }
    }
}

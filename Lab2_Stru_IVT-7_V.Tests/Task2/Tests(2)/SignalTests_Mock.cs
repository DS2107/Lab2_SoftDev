using Lab2_Stru_IVT_7_V.Tests.Classes_2_;
using Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab2_Stru_IVT_7_V.Tests.Tests_2_
{
    [TestClass]
    public class SignalTests_Mock
    {
        [TestMethod]
      
        public void PositiveValueTest()
        {
            var arrayProcessor = new Mock_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1,1,1,1,1 });
            Assert.AreEqual(1,arrayProcessor.positiveValue);
        }

        [TestMethod]
        public void ReverseArrayTest()
        {
            var arrayProcessor = new Mock_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1, 1, 1, 1, 1 });
            Assert.AreEqual(1,arrayProcessor.reverseArray);
        }

        [TestMethod]
        public void SortAndFilterTest()
        {
            var arrayProcessor = new Mock_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1, 1, 1, 1, 1 });
            Assert.AreEqual(1,arrayProcessor.sortAndFilter);
        }
    }
}

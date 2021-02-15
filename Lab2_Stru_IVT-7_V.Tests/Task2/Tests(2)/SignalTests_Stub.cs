using Lab2_Stru_IVT_7_V.Tests.Classes_2_;
using Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab2_Stru_IVT_7_V.Tests.Tests_2_
{
    [TestClass]
    public class SignalTests_Stub
    {
        [TestMethod]
       
        public void CalculateSumTest()
        {
            var arrayProcessor = new Stub_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1,1,1,1,1,1,1});
            Assert.AreEqual(66, signal.CalculateSum());
        }

        [TestMethod]
        public void CalculateDiffTest()
        {
            var arrayProcessor = new Stub_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1, 1, 1, 1, 1, 1, 1 });

            Assert.AreEqual(-46, signal.CalculateDiff());
        }

        [TestMethod]
        public void CalculateAverageTest()
        {

            var arrayProcessor = new Stub_ArrayProcessor();
            Signal signal = new Signal(arrayProcessor, new double[] { 1, 1, 1, 1, 1, 1, 1 });

            Assert.AreEqual(6.67, signal.CalculateAverage(60));
        }
    }
}

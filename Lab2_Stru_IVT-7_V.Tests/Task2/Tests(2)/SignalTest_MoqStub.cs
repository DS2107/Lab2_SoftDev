using Lab2_Stru_IVT_7_V.Tests.Classes_2_;
using Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Lab2_Stru_IVT_7_V.Tests.Tests_2_
{
    [TestClass]
    public class SignalTest_MoqStub
    {

        [TestMethod]
        public void CalculateSumTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(60, signal.CalculateSum());
        }

        [TestMethod]
        public void CalculateDiffTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(-30, signal.CalculateDiff());
        }

        [TestMethod]
        public void CalculateAverageTest()
        {
            var stub = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            stub.Setup(r => r.SortAndFilter(array)).Returns(new double[] { 15, 11, 10, 8, 6, 4, 3, 2, 1 });
            Signal signal = new Signal(stub.Object, array);
            Assert.AreEqual(6.67, signal.CalculateAverage(60));
        }
    }
}

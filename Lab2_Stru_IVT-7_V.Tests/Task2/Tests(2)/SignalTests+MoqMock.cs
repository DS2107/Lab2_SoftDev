using Lab2_Stru_IVT_7_V.Tests.Classes_2_;
using Lab2_Stru_IVT_7_V.Tests.Classes_2_.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Lab2_Stru_IVT_7_V.Tests.Tests_2_
{
    [TestClass]
    public class SignalTests_MoqMock
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IArrayProcessor>();
            double[] array = new double[] { 2, 1, 6, -2, 4, 8, -1, -3, 10, 11, 11, 15, 3 };
            Signal signal = new Signal(mock.Object, array);
            mock.Verify(r => r.SortAndFilter(array), Times.Once());
        }
    }
}

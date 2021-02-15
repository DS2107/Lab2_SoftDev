using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using Lab2_Stru_IVT_7_V.Tests.Classes_1_.DataAccessObjects;

namespace Lab2_Stru_IVT_7_V.Tests.Tests_1_
{
    [TestClass]
    public class ReportViewerTests_Moq
    {
        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IFileService>();
            var reportViewer = new ReportViewer(mock.Object);
            reportViewer.PrepareData();
            mock.Verify(r => r.MergeTemporaryFiles("tmpfile"), Times.Once());

        }

        [TestMethod]
        public void TestMethod2()
        {

            var stub = new Mock<IFileService>();
            stub.Setup(r => r.MergeTemporaryFiles("tmpfile")). Returns(4);
            var reportViewer = new ReportViewer(stub.Object);
            reportViewer.PrepareData();


            Assert.AreEqual(reportViewer.BlockCount, 0);

        }
    }
}

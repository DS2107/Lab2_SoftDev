
using Lab2_Stru_IVT_7_V.Tests.Classes_1_.DataAccessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Lab2_Stru_IVT_7_V.Tests
{
    [TestClass]
    public class ReportViewerTests
    {
        [TestMethod]
        public void FileDir_PrepareDate()
        {
            IFileService service = new StubFileService();
            ReportViewer reportViewer = new ReportViewer(service); // Dependency Injection

            Assert.IsTrue(reportViewer.PrepareData());

        } 

        [TestMethod]     
        public void FileCount()
        {
            var service = new MockFileService();
            ReportViewer reportViewer = new ReportViewer(service);
            reportViewer.PrepareData();


            Assert.AreEqual(1, service.count_tmpFiles);


        }

        [TestMethod]
        public void BlockCount()
        {
            IFileService service = new StubFileService();
            ReportViewer reportViewer = new ReportViewer(service);
            reportViewer.PrepareData();


            Assert.AreEqual(4, reportViewer.BlockCount);
        }
    }
}

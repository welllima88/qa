using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Administration.Article;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Administration.Article
{
    [TestClass]
    public class ArticleViewTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Article/Edit?Id=CF03DF69-5AE1-422B-8C37-DCE143157D98");
        }

        [TestMethod]
        public void ArticlelName()
        {
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", View.Name);
        }

        [TestMethod]
        public void SbsArticleNumber()
        {
            Assert.AreEqual("", View.SbsArticleNumber);
        }

        [TestMethod]
        public void Status()
        {
            Assert.IsTrue(View.Status);
        }

        [TestMethod]
        public void SupplierList()
        {
            CollectionAssert.AllItemsAreNotNull(View.Supplier);
        }

        [TestMethod]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(View.Supplier.Count > 0, "0 - :) or less elements");
        }

        [TestMethod]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(View.Supplier, "SIX Payment Services AG");
        }

        [TestMethod]
        public void Color()
        {
            Assert.AreEqual("white", View.Color);
        }

        [TestMethod]
        public void NetTypeEditWithoutSave()
        {
            Assert.AreEqual("TCPIPEP2IP", View.NetType);
        }

        [TestMethod]
        public void SoftwareId()
        {
            Assert.AreEqual("1095", View.SoftwareId);
        }

        [TestMethod]
        public void TrxSubmLim()
        {
            Assert.AreEqual("1", View.TrxSubmLim);
        }

        [TestMethod]
        public void TrxTransLim()
        {
            Assert.AreEqual("1", View.TrxTransLim);
        }

        [TestMethod]
        public void ContactlessIndicator()
        {
            Assert.AreEqual("1", View.ContactlessIndicator);
        }

        [TestMethod]
        public void CardReaderType()
        {
            Assert.AreEqual("3", View.CardReaderType);
        }

        [TestMethod]
        public void PosInterface()
        {
            Assert.AreEqual("VEZ", View.PosInterface);
        }

        [TestMethod]
        public void RecallInterval()
        {
            Assert.AreEqual("86400", View.RecallInterval);
        }
    }
}
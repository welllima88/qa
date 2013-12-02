using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.Article;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Administration.Article
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
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", ArticleView.Name);
        }

        [TestMethod]
        public void SbsArticleNumber()
        {
            Assert.AreEqual("", ArticleView.SbsArticleNumber);
        }

        [TestMethod]
        public void Status()
        {
            Assert.IsTrue(ArticleView.Status);
        }

        [TestMethod]
        public void SupplierList()
        {
            CollectionAssert.AllItemsAreNotNull(ArticleView.Supplier);
        }

        [TestMethod]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(ArticleView.Supplier.Count > 0, "0 - :) or less elements");
        }

        [TestMethod]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(ArticleView.Supplier, "SIX Payment Services AG");
        }

        [TestMethod]
        public void Color()
        {
            Assert.AreEqual("white", ArticleView.Color);
        }

        [TestMethod]
        public void NetTypeEditWithoutSave()
        {
            Assert.AreEqual("TCPIPEP2IP", ArticleView.NetType);
        }

        [TestMethod]
        public void SoftwareId()
        {
            Assert.AreEqual("1095", ArticleView.SoftwareId);
        }

        [TestMethod]
        public void TrxSubmLim()
        {
            Assert.AreEqual("1", ArticleView.TrxSubmLim);
        }

        [TestMethod]
        public void TrxTransLim()
        {
            Assert.AreEqual("1", ArticleView.TrxTransLim);
        }

        [TestMethod]
        public void ContactlessIndicator()
        {
            Assert.AreEqual("1", ArticleView.ContactlessIndicator);
        }

        [TestMethod]
        public void CardReaderType()
        {
            Assert.AreEqual("3", ArticleView.CardReaderType);
        }

        [TestMethod]
        public void PosInterface()
        {
            Assert.AreEqual("VEZ", ArticleView.PosInterface);
        }

        [TestMethod]
        public void RecallInterval()
        {
            Assert.AreEqual("86400", ArticleView.RecallInterval);
        }
    }
}
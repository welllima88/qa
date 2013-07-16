using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Article;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.Article
{
    [TestClass]
    public class ArticleViewTest
    {
        private static IArticle _articleView;


        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _articleView = new ArticleView();

            TestLauncher.Navigate("/Article/Edit?Id=CF03DF69-5AE1-422B-8C37-DCE143157D98");
        }

        [TestMethod]
        public void ArticlelName()
        {
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", _articleView.Name);
        }

        [TestMethod]
        public void SbsArticleNumber()
        {
            Assert.AreEqual("", _articleView.SbsArticleNumber);
        }

        [TestMethod]
        public void Status()
        {
            Assert.IsTrue(_articleView.Status);
        }

        [TestMethod]
        public void SupplierList()
        {
            CollectionAssert.AllItemsAreNotNull(_articleView.Supplier);
        }

        [TestMethod]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(_articleView.Supplier.Count > 0, "0 - :) or less elements");
        }

        [TestMethod]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(_articleView.Supplier, "SIX Payment Services AG");
        }

        [TestMethod]
        public void Color()
        {
            Assert.AreEqual("white", _articleView.Color);
        }

        [TestMethod]
        public void NetTypeEditWithoutSave()
        {
            Assert.AreEqual("TCPIPEP2IP", _articleView.NetType);
        }

        [TestMethod]
        public void SoftwareId()
        {
            Assert.AreEqual("1095", _articleView.SoftwareId);
        }

        [TestMethod]
        public void TrxSubmLim()
        {
            Assert.AreEqual("1", _articleView.TrxSubmLim);
        }

        [TestMethod]
        public void TrxTransLim()
        {
            Assert.AreEqual("1", _articleView.TrxTransLim);
        }

        [TestMethod]
        public void ContactlessIndicator()
        {
            Assert.AreEqual("1", _articleView.ContactlessIndicator);
        }

        [TestMethod]
        public void CardReaderType()
        {
            Assert.AreEqual("3", _articleView.CardReaderType);
        }

        [TestMethod]
        public void PosInterface()
        {
            Assert.AreEqual("VEZ", _articleView.PosInterface);
        }

        [TestMethod]
        public void RecallInterval()
        {
            Assert.AreEqual("86400", _articleView.RecallInterval);
        }
    }
}
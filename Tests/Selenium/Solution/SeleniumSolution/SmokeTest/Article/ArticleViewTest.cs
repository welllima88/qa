using NUnit.Framework;
using Six.Scs.QA.Selenium.Administration.Article;
using Six.Scs.QA.Selenium.Extension.WebDriver;

namespace Six.Scs.QA.Selenium.SmokeTest.Article
{
    [TestFixture]
    public class ArticleViewTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Article/Edit?Id=CF03DF69-5AE1-422B-8C37-DCE143157D98");
        }

        [Test]
        public void ArticlelName()
        {
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", View.Name);
        }

        [Test]
        public void CardReaderType()
        {
            Assert.AreEqual("3", View.CardReaderType);
        }

        [Test]
        public void Color()
        {
            Assert.AreEqual("white", View.Color);
        }

        [Test]
        public void ContactlessIndicator()
        {
            Assert.AreEqual("1", View.ContactlessIndicator);
        }

        [Test]
        public void NetTypeEditWithoutSave()
        {
            Assert.AreEqual("TCPIPEP2IP", View.NetType);
        }

        [Test]
        public void PosInterface()
        {
            Assert.AreEqual("MPD", View.PosInterface);
        }

        [Test]
        public void RecallInterval()
        {
            Assert.AreEqual("86400", View.RecallInterval);
        }

        [Test]
        public void SbsArticleNumber()
        {
            Assert.AreEqual("", View.SbsArticleNumber);
        }

        [Test]
        public void SoftwareId()
        {
            Assert.AreEqual("1095", View.SoftwareId);
        }

        [Test]
        public void Status()
        {
            Assert.IsTrue(View.Status);
        }

        [Test]
        public void SupplierList()
        {
            CollectionAssert.AllItemsAreNotNull(View.Supplier);
        }

        [Test]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(View.Supplier.Count > 0, "0 - :) or less elements");
        }

        [Test]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(View.Supplier, "SIX Payment Services AG");
        }

        [Test]
        public void TrxSubmLim()
        {
            Assert.AreEqual("1", View.TrxSubmLim);
        }

        [Test]
        public void TrxTransLim()
        {
            Assert.AreEqual("1", View.TrxTransLim);
        }
    }
}
using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Article
{
    [TestFixture]
    public class ViewTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("Article/Edit?Id=CF03DF69-5AE1-422B-8C37-DCE143157D98");
        }

        [Test]
        public void ArticlelName()
        {
            Assert.AreEqual("yomani XR S C O PINPAD, TCP/IP (IP)", View.Administration.Article.View.Name);
        }

        [Test]
        public void CardReaderType()
        {
            Assert.AreEqual("3", View.Administration.Article.View.CardReaderType);
        }

        [Test]
        public void Color()
        {
            Assert.AreEqual("white", View.Administration.Article.View.Color);
        }

        [Test]
        public void ContactlessIndicator()
        {
            Assert.AreEqual("1", View.Administration.Article.View.ContactlessIndicator);
        }

        [Test]
        public void NetTypeEditWithoutSave()
        {
            Assert.AreEqual("TCPIPEP2IP", View.Administration.Article.View.NetType);
        }

        [Test]
        public void PosInterface()
        {
            Assert.AreEqual("MPD", View.Administration.Article.View.PosInterface);
        }

        [Test]
        public void RecallInterval()
        {
            Assert.AreEqual("86400", View.Administration.Article.View.RecallInterval);
        }

        [Test]
        public void SbsArticleNumber()
        {
            Assert.AreEqual("", View.Administration.Article.View.SbsArticleNumber);
        }

        [Test]
        public void SoftwareId()
        {
            Assert.AreEqual("1095", View.Administration.Article.View.SoftwareId);
        }

        [Test]
        public void Status()
        {
            Assert.IsTrue(View.Administration.Article.View.Status);
        }

        [Test]
        public void SupplierList()
        {
            CollectionAssert.AllItemsAreNotNull(View.Administration.Article.View.Supplier);
        }

        [Test]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(View.Administration.Article.View.Supplier.Count > 0, "0 - :) or less elements");
        }

        [Test]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(View.Administration.Article.View.Supplier, "SIX Payment Services AG");
            CollectionAssert.Contains(View.Administration.Article.View.Supplier, "SIX Payment Services AT");
        }

        [Test]
        public void TrxSubmLim()
        {
            Assert.AreEqual("1", View.Administration.Article.View.TrxSubmLim);
        }

        [Test]
        public void TrxTransLim()
        {
            Assert.AreEqual("1", View.Administration.Article.View.TrxTransLim);
        }
    }
}
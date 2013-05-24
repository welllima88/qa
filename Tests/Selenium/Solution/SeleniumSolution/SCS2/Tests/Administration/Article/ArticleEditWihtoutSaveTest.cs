using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.Article;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Administration.Article
{
    [TestClass]
    public class ArticleEditWihtoutSaveTest
    {
        private static ArticleEdit _articleEdit;
        private static TestDirector _tb;

        private static IWebDriverAdapter _driver;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _articleEdit = new ArticleEdit(_driver);

            _driver.Url = _tb.BaseUrl + "/Article/Edit?Id=331E7506-8852-4C5D-8D6C-6916235AF07B";
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //_customerView.

            //after last test-method finished
            _tb.ShutDownTest();
        }


        [TestMethod]
        public void ArticlelNameEditWithoutSave()
        {
            _articleEdit.Name = "xenta AUTONOM WLAN TCP/IP";
        }

        [TestMethod]
        public void SbsArticleNumberEditWithoutSave()
        {
            _articleEdit.SbsArticleNumber = "15464";
        }

        [TestMethod]
        public void StatusEditWithoutSave()
        {
            _articleEdit.Status = true;
        }

        [TestMethod]
        public void SupplierListIsShown()
        {
            CollectionAssert.AllItemsAreNotNull(_articleEdit.Supplier);
        }

        [TestMethod]
        public void SupplierListHasAtLeastOneElement()
        {
            Assert.IsTrue(_articleEdit.Supplier.Count > 0, "0 or less elements");
        }

        [TestMethod]
        public void SupplierListHasSixSupplierElement()
        {
            CollectionAssert.Contains(_articleEdit.Supplier, "SIX Payment Services AG");
        }

        [TestMethod]
        public void TerminalTypeEditWithoutSave()
        {
            _articleEdit.TerminalType = "xenta AUTONOM";
        }

        [TestMethod]
        public void NetTypeEditWithoutSave()
        {
            _articleEdit.NetType = "TCP/IP ep2 (DNS)";
        }

        [TestMethod]
        public void CashIntegratedEditWithoutSave()
        {
            _articleEdit.CashIntegrated = "Cash Integrator";
        }
    }
}
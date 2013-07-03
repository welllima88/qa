using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateGuiTest
    {
        private static IWebDriverAdapter _driver;
        private static NavigationBar _navigationBar;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;
        private static LobbyMenu _lobbyMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _lobbyMenu = new LobbyMenu(_driver);
            _customerMenu = new CustomerMenu(_driver);
            _navigationBar = new NavigationBar(_driver);
            _menusTests = new MenusTest();
            _lobby = new LobbyView(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _driver.Url = _tb.BaseUrl + "/Default.aspx";
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateCustomerNavigationBar()
        {
            _customerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", _navigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateCustomerHeadline()
        {
            StringAssert.Contains("Lobby", _lobby.Headline.Text);
            _customerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", _lobby.Headline.Text);
        }
    }
}
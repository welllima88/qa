using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateGuiTest
    {
        private static NavigationBar _navigationBar;
        private static CustomerMenu _customerMenu;
        private static LobbyMenu _lobbyMenu;
        private static MenusTest _menusTests;
        private static LobbyView _lobby;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _lobbyMenu = new LobbyMenu();
            _customerMenu = new CustomerMenu();
            _navigationBar = new NavigationBar();
            _menusTests = new MenusTest();
            _lobby = new LobbyView();
        }

        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("");
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
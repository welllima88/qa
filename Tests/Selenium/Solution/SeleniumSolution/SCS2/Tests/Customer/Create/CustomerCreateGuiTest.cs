using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create
{
    [TestClass]
    public class CustomerCreateGuiTest
    {
        [TestInitialize]
        public void TestInit()
        {
            TestLauncher.Navigate("");
        }

        [TestMethod]
        public void CreateCustomerNavigationBar()
        {
            CustomerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void CreateCustomerHeadline()
        {
            StringAssert.Contains("Lobby", LobbyView.Headline.Text);
            CustomerMenu.CustomerCreate.Click();
            Assert.AreEqual("Neuer Kunde", LobbyView.Headline.Text);
        }
    }
}
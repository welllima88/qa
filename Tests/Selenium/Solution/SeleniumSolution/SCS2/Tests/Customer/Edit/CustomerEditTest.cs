using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Customer;
using Six.Scs.QA.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;
using Six.Scs.QA.Selenium.Tests.Menu;

namespace Six.Scs.QA.Selenium.Tests.Customer.Edit
{
    [TestClass]
    public class CustomerEditTest
    {
        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?customerId=402200");
        }

        [TestMethod]
        public void EditCustomerAndSave()
        {
            StringAssert.Matches(CustomerView.SbsAdressNumber, TestRegExpPatterns.SbsAdressNoOpt);
            StringAssert.Matches(CustomerView.SbsDebitNumber, TestRegExpPatterns.SbsDebitorNo);
            StringAssert.Matches(CustomerView.Ep2MerchantId, TestRegExpPatterns.Ep2MerchantId);

            CustomerData c = CustomerFactory.Edit();
            CustomerService.Edit(c);
            CustomerService.Check(c);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            CustomerService.Check(c);
        }

        [TestMethod]
        public void EditCustomerCheckNavBar()
        {
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
            CustomerMenu.CustomerEdit.Click();
            Assert.AreEqual("Kunde", NavigationBar.Current.Text);
        }

        [TestMethod]
        public void EditCustomerCheckMenu()
        {
            MenusTest.CustomerMenuCheck();
            CustomerMenu.CustomerEdit.Click();
            MenusTest.CustomerMenuCheck();
        }

        [TestMethod]
        public void EditCustomerCheckHeadline()
        {
            StringAssert.Matches(LobbyView.Headline.Text, new Regex(@"\d+:.*"));
            string headLine = LobbyView.Headline.Text;
            CustomerMenu.CustomerEdit.Click();
            StringAssert.Contains(LobbyView.Headline.Text, headLine);
        }
    }
}
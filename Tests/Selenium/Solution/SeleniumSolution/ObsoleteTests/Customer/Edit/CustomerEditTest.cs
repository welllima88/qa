using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Customer;
using Six.Scs.QA.Selenium.Extension;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.ObsoleteTests.Menu;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Customer.Edit
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
            StringAssert.Matches(CustomerView.SbsAdressNumber, new Regex(TestRegExpPatterns.SbsAdressNoOpt));
            StringAssert.Matches(CustomerView.SbsDebitNumber, new Regex(TestRegExpPatterns.SbsDebitorNo));
            StringAssert.Matches(CustomerView.Ep2MerchantId, new Regex(TestRegExpPatterns.Ep2MerchantId));

            TestData.ValueObjects.Customer c = TestData.Factory.Customer.Edit();
            Workflow.Customer.Edit(c);
            Testlogic.Customer.Check(c);

            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Testlogic.Customer.Check(c);
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
            StringAssert.Matches(Lobby.Headline.Text, new Regex(@"\d+:.*"));
            string headLine = Lobby.Headline.Text;
            CustomerMenu.CustomerEdit.Click();
            StringAssert.Contains(Lobby.Headline.Text, headLine);
        }
    }
}
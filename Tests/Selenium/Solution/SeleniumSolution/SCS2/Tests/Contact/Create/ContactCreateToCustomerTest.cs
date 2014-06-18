using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.QA.Selenium.Extension.TestObjects.Definitions;
using Six.Scs.QA.Selenium.Extension.TestObjects.Person;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;

namespace Six.Scs.QA.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateToCustomerTest
    {
        private static ContactPersonData _p;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            CustomerMenu.ContactCreate.Click();

            _p = ContactPersonFactory.Create();
            ContactService.Create(_p);
        }

        [TestMethod]
        public void Contact()
        {
            ContactService.Check(_p);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            ContactService.Check(_p);
        }

        [ClassCleanup]
        public static void DeleteContact()
        {
            ContactPersonView.DeleteButton.Click();
            ContactPersonView.DeleteConfirm();
        }
    }
}
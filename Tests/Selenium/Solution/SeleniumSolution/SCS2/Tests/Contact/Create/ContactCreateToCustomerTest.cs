using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestData;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Person;
using SIX.SCS.Tests.Selenium.Extension.Worklow;

namespace SIX.SCS.Tests.Selenium.Tests.Contact.Create
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

            _p = Factory.ContactPerson.Create();
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
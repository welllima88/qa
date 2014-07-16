using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Common;
using Six.Scs.QA.Selenium.Common.Menu;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Person;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Selenium.ObsoleteTests.Contact.Create
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
            Workflow.Contact.Create(_p);
        }

        [TestMethod]
        public void Contact()
        {
            Testlogic.Contact.Check(_p);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Testlogic.Contact.Check(_p);
        }

        [ClassCleanup]
        public static void DeleteContact()
        {
            ContactPersonView.DeleteButton.Click();
            ContactPersonView.DeleteConfirm();
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.QA.Selenium.Extension.TestData;
using Six.Scs.QA.Selenium.Extension.TestData.Factory;
using Six.Scs.QA.Selenium.Extension.TestData.ValueObjects;
using Six.Scs.QA.Selenium.Extension.TestObjects.Common;
using Six.Scs.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Extension.Worklow;
using Six.Scs.QA.Selenium.Tests.Menu;

namespace Six.Scs.QA.Selenium.Tests.Contact.Edit
{
    [TestClass]
    public class ContactEditTest
    {
        private static string _contactId;
        private static ContactPersonData _p;

        [ClassInitialize]
        public static void TestInit(TestContext testContext)
        {
            _contactId = "31432";
            TestDirector.Navigate("Person/?PERSONID=" + _contactId);

            _p = ContactPersonFactory.Edit();
            ContactService.Edit(_p);
        }

        [TestMethod]
        public void ContactMenuCheck()
        {
            MenusTest.ContactMenuCheck();
        }

        [TestMethod]
        public void Salutation()
        {
            ContactService.Check(_p);
        }

        [TestMethod]
        public void MostRecentElement()
        {
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();
        }
    }
}
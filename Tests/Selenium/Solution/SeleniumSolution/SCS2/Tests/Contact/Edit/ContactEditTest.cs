using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestData;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.Tests.Selenium.Extension.Worklow;
using SIX.SCS.Tests.Selenium.Tests.Menu;

namespace SIX.SCS.Tests.Selenium.Tests.Contact.Edit
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

            _p = Factory.ContactPerson.Edit();
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
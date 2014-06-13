using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.Tests.Selenium.Extension.Selenium;
using SIX.SCS.Tests.Selenium.Extension.TestData;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.Tests.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.Tests.Selenium.Extension.Worklow;

namespace SIX.SCS.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateToLocationTest
    {
        private static ContactPersonData _p;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Customer/?CustomerId=401152");

            _p = Factory.ContactPerson.Create();
            LocationMenu.ContactCreate.Click();
            ContactService.Create(_p);
        }

        [TestMethod]
        public void FirstName()
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
    }
}
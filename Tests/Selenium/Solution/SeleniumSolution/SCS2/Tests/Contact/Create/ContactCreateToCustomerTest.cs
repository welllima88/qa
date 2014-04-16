﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
using SIX.SCS.QA.Selenium.Extension.Worklow;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
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
        [TestMethod]
        public static void DeleteContact()
        {
            ContactPersonView.DeleteButton.Click();
            ContactPersonView.DeleteConfirm();
        }
    }
}
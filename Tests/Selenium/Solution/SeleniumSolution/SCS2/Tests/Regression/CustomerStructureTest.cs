using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class CustomerStructureTest
    {
        private static string _customerNumber;
        private static string _locationGuid;
        private static string _locationName;
        private static string _customerName;
        private static string _contactCustomerName;
        private static string _contactLocationName;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerCreateTest.DoCreateCustomer();

            _customerNumber = CustomerView.CustomerNumber;
            _customerName = CustomerView.CustomerName;

            CustomerMenu.ContactCreate.Click();
            ContactCreateTest.DoCreateContact();
            _contactCustomerName = ContactPersonView.FirstName;

            LocationCreateTest.DoCreateLocation();
            _locationGuid = LocationView.Guid;
            _locationName = LocationView.CompanyName;

            LocationMenu.ContactCreate.Click();
            ContactCreateTest.DoCreateContact();
            _contactLocationName = ContactPersonView.FirstName;
        }

        [TestMethod]
        public void CustomerCanBeFoundByCustomerId()
        {
            QuickSearch.SearchField = _customerNumber;
            QuickSearch.HitEnter();

            CustomerResult.Result().Click();

            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        [TestMethod]
        public void CustomerCanBeFoundByCustomerName()
        {
            QuickSearch.SearchField = _customerName;
            QuickSearch.HitEnter();

            CustomerResult.Result().Click();

            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        [TestMethod]
        public void LocationCanBeFoundByLocationName()
        {
            QuickSearch.SearchField = _locationName;
            QuickSearch.SearchButton.Click();

            LocationResult.Result().Click();

            Assert.AreEqual(_locationGuid, LocationView.Guid);
            Assert.AreEqual(_locationName, LocationView.CompanyName);
        }

        [TestMethod]
        public void ContactToCustomerIsCreated()
        {
            CustomerCanBeFoundByCustomerId();

            CustomerMenu.Contacts.Click();
            
            ContactList.First().Click();

            Assert.AreEqual(_contactCustomerName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void ContactToLocationIsCreated()
        {
            LocationCanBeFoundByLocationName();

            LocationMenu.Contacts.Click();

            ContactList.First().Click();
            Assert.AreEqual(_contactLocationName, ContactPersonView.FirstName);
        }
    }
}
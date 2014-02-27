using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;
using SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class CustomerStructureTest
    {
        private static string _customerNumber;
        private static string _locationGuid;
        private static string _locationSbsDebitNumber;
        private static string _customerName;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerCreateTest.DoCreateCustomer();

            _customerNumber = CustomerView.CustomerNumber;
            _customerName = CustomerView.CustomerName;

            CustomerMenu.ContactCreate.Click();
            ContactCreateTest.SetContactData();

            LocationCreateAndSaveTest.DoCreateLocation();
            _locationGuid = LocationView.Guid;
            _locationSbsDebitNumber = LocationView.SbsDebitNumber;

            LocationMenu.ContactCreate.Click();
            ContactCreateTest.SetContactData();
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            CustomerMenu.CustomerDeactivate.Click();
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
            
            CustomerResult.Result(_customerNumber).Click();

            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
            Assert.AreEqual(_customerName, CustomerView.CustomerName);
        }

        [TestMethod]
        public void LocationCanBeFoundByLocationName()
        {

            LocationResult.Result().Click();

            Assert.AreEqual(_locationGuid, LocationView.Guid);
            Assert.AreEqual(_locationSbsDebitNumber, LocationView.SbsDebitNumber);
        }

        [TestMethod]
        public void ContactToCustomerIsCreated()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
        }

        [TestMethod]
        public void ContactToLocationIsCreated()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
        }
    }
}
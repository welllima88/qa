using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer.Create;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Location.Create;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Location;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Regression
{
    [TestClass]
    public class CustomerStructureTest
    {
        private string _customerNumber;
        private string _locationGuid;

        [TestInitialize]
        public void TestInit()
        {
            CustomerCreateTest.SetCustomerData();

            _customerNumber = CustomerView.CustomerNumber;

            CustomerMenu.ContactCreate.Click();
            ContactCreateTest.SetContactData();

            LocationCreateAndSaveTest.SetLocationData();
            _locationGuid = LocationView.Guid;

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
        public void CustomerIsCreated()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
        }

        [TestMethod]
        public void LocationIsCreated()
        {
            Assert.AreEqual(_customerNumber, CustomerView.CustomerNumber);
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
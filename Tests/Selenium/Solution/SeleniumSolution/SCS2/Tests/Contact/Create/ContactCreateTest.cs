using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestData;
using SIX.SCS.QA.Selenium.Extension.Selenium;
using SIX.SCS.QA.Selenium.Extension.TestData;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Person;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Contact.Create
{
    [TestClass]
    public class ContactCreateTest
    {
        private static string _firstName;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401152");
            // TestDirector.Navigate(TestDataRepository.Customer.GetAny());
            _firstName = "SYR" + TestLauncher.GenerateTestId();
            CustomerMenu.ContactCreate.Click();

            ContactPersonCreate.Salutation = "Herr";
            ContactPersonCreate.FirstName = _firstName;
            ContactPersonCreate.Name = "Siegmund SYR AUTO";
            ContactPersonCreate.Language = "de";
            ContactPersonCreate.Telephone = "+41 58 399 6237 - 1";
            ContactPersonCreate.Mobile = "+41 58 399 6237 - 2";
            ContactPersonCreate.Fax = "+41 58 399 6237 - 3";
            ContactPersonCreate.Email = "contact@six-group.com";
            ContactPersonCreate.StreetNo = "Kontakt-Weg 1";
            ContactPersonCreate.Po = "POC";
            ContactPersonCreate.Zip = "55555";
            ContactPersonCreate.City = "Berlin";
            ContactPersonCreate.Region = "Mitte";
            ContactPersonCreate.Country = "DE";
            ContactPersonCreate.AddressAddition = "Zusatz1";
            ContactPersonCreate.Web = "www.six-group.com";

            ContactPersonCreate.SaveButton.Click();
        }

        [TestMethod]
        public void FirstName()
        {
            Assert.AreEqual(_firstName, ContactPersonView.FirstName);
        }

        [TestMethod]
        public void LastName()
        {
            Assert.AreEqual("Siegmund SYR AUTO", ContactPersonView.Name);
        }

        [TestMethod]
        public void Language()
        {
            StringAssert.Contains(ContactPersonView.Language, "[de]");
        }

        [TestMethod]
        public void Telephone()
        {
            Assert.AreEqual("+41 58 399 6237 - 1", ContactPersonView.Telephone);
        }

        [TestMethod]
        public void Mobile()
        {
            Assert.AreEqual("+41 58 399 6237 - 2", ContactPersonView.Mobile);
        }

        [TestMethod]
        public void Fax()
        {
            Assert.AreEqual("+41 58 399 6237 - 3", ContactPersonView.Fax);
        }

        [TestMethod]
        public void Email()
        {
            Assert.AreEqual("contact@six-group.com", ContactPersonView.Email);
        }

        [TestMethod]
        public void Street()
        {
            Assert.AreEqual("Kontakt-Weg 1", ContactPersonView.StreetNo);
        }

        [TestMethod]
        public void Po()
        {
            Assert.AreEqual("POC", ContactPersonView.Po);
        }

        [TestMethod]
        public void Zip()
        {
            Assert.AreEqual("55555", ContactPersonView.Zip);
        }

        [TestMethod]
        public void RegionCreateContactAndSave()
        {
            Assert.AreEqual("Mitte", ContactPersonView.Region);
        }

        [TestMethod]
        public void City()
        {
            Assert.AreEqual("Berlin", ContactPersonView.City);
        }

        [TestMethod]
        public void Country()
        {
            StringAssert.Contains(ContactPersonView.Country, "[DE]");
        }

        [TestMethod]
        public void AddressAddition()
        {
            Assert.AreEqual("Zusatz1", ContactPersonView.AddressAddition);
        }

        [TestMethod]
        public void Web()
        {
            Assert.AreEqual("www.six-group.com", ContactPersonView.Web);
        }

        [TestMethod]
        public void RecentElementsCheck()
        {
            // string url = TestDirector.WebDriver.Url;
            NavigationBar.Lobby.Click();
            RecentElements.MostRecent.Click();
            // Assert.AreEqual(url, TestDirector.WebDriver.Url);
        }
    }
}
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Customer;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Customer
{
    public class CustomerTestInInternetExplorer
    {
        private static CustomerCreate CustomerCreate;
        private static CustomerView CustomerView;
        private static FormAlert _formAlert;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static CustomerMenu CustomerMenu;
        private long _dt;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            CustomerCreate = new CustomerCreate();
            CustomerView = new CustomerView();
            _recentElements = new RecentElements();
            _navigationBar = new NavigationBar();
            _formAlert = new FormAlert();
            CustomerMenu = new CustomerMenu();
        }

        [TestInitialize]
        public void TestInit()
        {
            NavigationBar.Lobby.Click();
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void CreateCustomerAndCancel()
        {
            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.CustomerName = "Selenium Test will cancel";
            CustomerCreate.Supplier = "SIX Payment Services AG";
//            There are two places where the IE driver does not interact with elements using native events. This is in clicking <option> elements within a <select> element. Under normal circumstances, the IE driver calculates where to click based on the position and size of the element, typically as returned by the JavaScript getBoundingClientRect() method. However, for <option> elements, getBoundingClientRect() returns a rectangle with zero position and zero size. The IE driver handles this one scenario by using the click() Automation Atom, which essentially sets the .selected property of the element and simulates the onChange event in JavaScript. However, this means that if the onChange event of the <select> element contains JavaScript code that calls alert(), confirm() or prompt(), calling WebElement's click() method will hang until the modal dialog is manually dismissed. There is no known workaround for this behavior using only WebDriver code. 
//
//Similarly, there are some scenarios when submitting an HTML form via WebElement's submit() method may have the same effect. This can happen if the driver calls the JavaScript submit() function on the form, and there is an onSubmit event handler that calls the JavaScript alert(), confirm(), or prompt() functions.

            //http://stackoverflow.com/questions/11430773/javascript-with-webdriver-selenium-2
            CustomerCreate.StreetNo = "Hardturmstr. 201";
            CustomerCreate.Zip = "5555";
            CustomerCreate.City = "Zürich";
            CustomerCreate.SbsCurrency = "EUR";

            CustomerCreate.CancelButton.Click();
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerWithIncompleteDataFailed()
        {
            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.CustomerName = "Selenium Test should fail";

            CustomerCreate.SaveButton.Click();
            // wrong check, no exception thrown if element not present and get Text
            // better positive check on the one hand could be another exception (timeout) on the other hand 
            // like: still in customer edit page or formalert
            //Assert.IsTrue(_navigationChecks.CheckUrlContains("PageMode=Edit"));
            Assert.IsTrue(FormAlert.FormAlertElements.Count > 0);
            CustomerCreate.CancelButton.Click();
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerAndSave()
        {
            CustomerMenu.CustomerCreate.Click();
            CustomerCreate.Supplier = "SIX Payment Services AG";
            CustomerCreate.SbsCurrency = "EUR";
            CustomerCreate.CustomerName = "Selenium Test IE";

            CustomerCreate.CompanyName = "SYR Firma DEMO" + _dt;
            CustomerCreate.StreetNo = "Hardturmstr. 201";
            CustomerCreate.Zip = "5555";
            CustomerCreate.City = "Zürich";

            CustomerCreate.SaveButton.Click();

            Assert.AreEqual("Selenium Test IE", CustomerView.CustomerName);
            NavigationBar.Lobby.Click();
            RecentElements.Latest.Click();

            Assert.AreEqual("Selenium Test IE", CustomerView.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", CustomerView.Supplier);
            Assert.AreEqual("EUR", CustomerView.SbsCurrency);

            Assert.AreEqual("Hardturmstr. 201", CustomerView.StreetNo);
            Assert.AreEqual("SYR Firma DEMO" + _dt, CustomerView.CompanyName);
            Assert.AreEqual("5555", CustomerView.Zip);
            Assert.AreEqual("Zürich", CustomerView.City);
        }
    }
}
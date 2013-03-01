using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Customer
{
    [TestClass]
    public class CustomerTestInInternetExplorer
    {
        private static CustomerCreate _customerCreate;
        private static CustomerView _customerView;
        private static IWebDriverAdapter _driver;
        private static FormAlert _formAlert;
        private static NavigationBar _navigationBar;
        private static RecentElements _recentElements;
        private static TestDirector _tb;
        private static CustomerMenu _customerMenu;
        private long _dt;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            // no need Test
            //run IEDriverServer:           
            _tb = new Scs2TestDirector("IE");
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login
            _customerCreate = new CustomerCreate(_driver);
            _customerView = new CustomerView(_driver);
            _recentElements = new RecentElements(_driver);
            _navigationBar = new NavigationBar(_driver);
            _formAlert = new FormAlert(_driver);
            _customerMenu = new CustomerMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
            _navigationBar.Lobby.Click();
            _dt = DateTime.Now.Ticks; //timestamp for each test
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            ////not necessary: Scs2TestDirector does it!
            //_ieDriverServer.Close();            
            //_ieDriverServer.Kill();
            _tb.ShutDownTest();
        }

        [TestMethod]
        public void CreateCustomerAndCancel()
        {
            _customerMenu.CustomerCreate.Click();
            _customerCreate.CustomerName = "Selenium Test will cancel";
            _customerCreate.Supplier = "SIX Payment Services AG";
//            There are two places where the IE driver does not interact with elements using native events. This is in clicking <option> elements within a <select> element. Under normal circumstances, the IE driver calculates where to click based on the position and size of the element, typically as returned by the JavaScript getBoundingClientRect() method. However, for <option> elements, getBoundingClientRect() returns a rectangle with zero position and zero size. The IE driver handles this one scenario by using the click() Automation Atom, which essentially sets the .selected property of the element and simulates the onChange event in JavaScript. However, this means that if the onChange event of the <select> element contains JavaScript code that calls alert(), confirm() or prompt(), calling WebElement's click() method will hang until the modal dialog is manually dismissed. There is no known workaround for this behavior using only WebDriver code. 
//
//Similarly, there are some scenarios when submitting an HTML form via WebElement's submit() method may have the same effect. This can happen if the driver calls the JavaScript submit() function on the form, and there is an onSubmit event handler that calls the JavaScript alert(), confirm(), or prompt() functions.


            //http://stackoverflow.com/questions/11430773/javascript-with-webdriver-selenium-2
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "5555";
            _customerCreate.City = "Zürich";
            _customerCreate.SbsCurrency = "EUR";

            _customerCreate.CancelButton.Click();
            Assert.IsTrue(_customerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerWithIncompleteDataFailed()
        {
            _customerMenu.CustomerCreate.Click();
            _customerCreate.CustomerName = "Selenium Test should fail";

            _customerCreate.SaveButton.Click();
            // wrong check, no exception thrown if element not present and get Text
            // better positive check on the one hand could be another exception (timeout) on the other hand 
            // like: still in customer edit page or formalert
            //Assert.IsTrue(_navigationChecks.CheckUrlContains("PageMode=Edit"));
            Assert.IsTrue(_formAlert.FormAlertElements.Count > 0);
            _customerCreate.CancelButton.Click();
            Assert.IsTrue(_customerMenu.CustomerCreate.Displayed);
        }

        [TestMethod]
        public void CreateCustomerAndSave()
        {
            _customerMenu.CustomerCreate.Click();
            _customerCreate.Supplier = "SIX Payment Services AG";
            _customerCreate.SbsCurrency = "EUR";
            _customerCreate.CustomerName = "Selenium Test IE";

            _customerCreate.CompanyName = "SYR Firma DEMO" + _dt;
            _customerCreate.StreetName = "Hardturmstr. 201";
            _customerCreate.Zip = "5555";
            _customerCreate.City = "Zürich";

            _customerCreate.SaveButton.Click();

            Assert.AreEqual("Selenium Test IE", _customerView.CustomerName);
            _navigationBar.Lobby.Click();
            _recentElements.MostRecent.Click();

            Assert.AreEqual("Selenium Test IE", _customerView.CustomerName);
            Assert.AreEqual("SIX Payment Services AG", _customerView.Supplier);
            Assert.AreEqual("EUR", _customerView.SbsCurrency);

            Assert.AreEqual("Hardturmstr. 201", _customerView.StreetName);
            Assert.AreEqual("SYR Firma DEMO" + _dt, _customerView.CompanyName);
            Assert.AreEqual("5555", _customerView.Zip);
            Assert.AreEqual("Zürich", _customerView.City);
        }
    }
}
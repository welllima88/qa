using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.Tests.Menu
{
    [TestClass]
    public class MenusTest
    {
        private static TestDirector _tb;
        private static IWebDriverAdapter _driver;
        private static CustomerMenu _customerMenu;
        private static LocationMenu _locationMenu;
        private static TerminalMenu _terminalMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            //before first test-method starts
            _tb = new ScsPlatinTestDirector();
            _driver = _tb.DefaultTestSetup(); //default QA-L with certificate login and 10 seconds response timeout
            _customerMenu = new CustomerMenu(_driver);
            _locationMenu = new LocationMenu(_driver);
            _terminalMenu = new TerminalMenu(_driver);
        }

        [TestInitialize]
        public void TestInit()
        {
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            //after last test-method finished
            _tb.ShutDownTest();
        }


        [TestMethod]
        public void CustomerMenuTest()
        {
            _driver.Url = _tb.BaseUrl + "/Pages/Customer/CustomerEdit.aspx?CustomerId=85036";
            CustomerMenuCheck(_customerMenu);
        }

        [TestMethod]
        public void LocationMenuTest()
        {
            _driver.Url = _tb.BaseUrl + "/Location/?LocationId=13404719-47a4-4686-8e22-161d3cd9903e";
            LocationMenuCheck(_locationMenu);
            _customerMenu.Customer.Click();
            CustomerMenuCheck(_customerMenu);
        }

        [TestMethod]
        public void TerminalMenuTest()
        {
            _driver.Url = _tb.BaseUrl +
                          "/Pages/Terminal/TerminalView.aspx?PageMode=view&CustomerId=400805&TerminalId=30980051";

            TerminalMenuCheck(_terminalMenu);

            //CustomerMenuCheck(_customerMenu);

            //// depending, where the terminal is created a location menu is displayed
            //if (_locationMenu.Location.Displayed)
            //{
            //    LocationMenuCheck(_locationMenu);
            //}
        }

        private static void TerminalMenuCheck(TerminalMenu terminalMenu)
        {
            Assert.IsTrue(terminalMenu.Terminal.Displayed);
            Assert.IsTrue(terminalMenu.ContractCreate.Displayed);
            Assert.IsTrue(terminalMenu.InfotextCreate.Displayed);
            Assert.IsTrue(terminalMenu.TicketCreate.Displayed);
            Assert.IsTrue(terminalMenu.ServiceCenterCreate.Displayed);
            Assert.IsTrue(terminalMenu.PmsCreate.Displayed);
            Assert.IsTrue(terminalMenu.Edit.Displayed);
            Assert.IsTrue(terminalMenu.Quit.Displayed);
            Assert.IsTrue(terminalMenu.Duplicate.Displayed);
            Assert.IsTrue(terminalMenu.Replace.Displayed);
            Assert.IsTrue(terminalMenu.Tickets.Displayed);
            Assert.IsTrue(terminalMenu.Infotexts.Displayed);
            Assert.IsTrue(terminalMenu.Forms.Displayed);

            terminalMenu.AnalysisMenu.TerminalAnalysis.Click();

            Assert.IsTrue(terminalMenu.AnalysisMenu.GklpBlock.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.SetFastInitFlag.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.ResetComAdresses.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.TerminalEvents.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.FoMessages.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.FoQueries.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.Ep2TraceLog.Displayed);
            Assert.IsTrue(terminalMenu.AnalysisMenu.SendOverview.Displayed);
        }

        private void TryOut()
        {
            //css is horr for text stuff -> consequence will be I use fance xpath!!!
            //http://sqa.stackexchange.com/questions/362/a-way-to-match-on-text-using-css-locators
            //http://sauceio.com/index.php/2010/03/selenium-tips-finding-elements-by-their-inner-text-using-contains-a-css-pseudo-class/
            //http://net.tutsplus.com/tutorials/html-css-techniques/the-30-css-selectors-you-must-memorize/

            //http://darrellgrainger.blogspot.ch/2012/01/css-for-webdriver-revisited.html
            IWebElement e = _driver.FindElement(By.CssSelector("a[href*='Customer/CustomerEdit.aspx?PageMode=new']"));
            _driver.FindElement(By.CssSelector("td[textContent=\" Neuer Kunde\"]"));
            _driver.FindElement(By.CssSelector("td:contains(\" Neuer Kunde\"]"));
            _driver.FindElement(By.CssSelector("td[textContent=' Neuer Kunde']"));
            _driver.FindElement(By.CssSelector("td::contains(' Neuer Kunde')"));
            _driver.FindElement(By.CssSelector("td[innertext='Neuer Kunde']"));
            _driver.FindElement(By.CssSelector("td:contains('^ Neuer Kunde$')"));
            _driver.FindElement(By.CssSelector("td[textContent=' Neuer Kunde']"));
            _driver.FindElement(By.CssSelector("td[textContent=\" Neuer Kunde\"]"));
            _driver.FindElement(By.XPath("//td[text()=' Kunde']"));
            e.Click();
        }

        // change to a more generic solution (list of elements <testobj>)
        public void CustomerMenuCheck(CustomerMenu customerMenu)
        {
            Assert.IsTrue(customerMenu.CustomerCreate.Displayed);
            Assert.IsTrue(customerMenu.CustomerEdit.Displayed);
            Assert.IsTrue(customerMenu.CustomerQuit.Displayed);
            Assert.IsTrue(customerMenu.Customer.Displayed);

            Assert.IsTrue(customerMenu.LocationsOfCustomer.Displayed);
            Assert.IsTrue(customerMenu.LocationCreate.Displayed);

            Assert.IsTrue(customerMenu.BillingAdresses.Displayed);
            Assert.IsTrue(customerMenu.BillingAdressCreate.Displayed);

            Assert.IsTrue(customerMenu.Tickets.Displayed);

            Assert.IsTrue(customerMenu.Contacts.Displayed);
            Assert.IsTrue(customerMenu.ContactCreate.Displayed);

            Assert.IsTrue(customerMenu.Users.Displayed);
            Assert.IsTrue(customerMenu.UserCreate.Displayed);

            Assert.IsTrue(customerMenu.TerminalCreate.Displayed);
            Assert.IsTrue(customerMenu.TerminalsOfCustomerLocation.Displayed);
            Assert.IsTrue(customerMenu.TerminalsOfCustomerLocation.Displayed);
        }

        public void LocationMenuCheck(LocationMenu locationMenu)
        {
            Assert.IsTrue(locationMenu.Location.Displayed);
            Assert.IsTrue(locationMenu.LocationEdit.Displayed);
            Assert.IsTrue(locationMenu.LocationQuit.Displayed);

            Assert.IsTrue(locationMenu.Contacts.Displayed);
            Assert.IsTrue(locationMenu.ContactCreate.Displayed);

            Assert.IsTrue(locationMenu.InfotextCreate.Displayed);
            Assert.IsTrue(locationMenu.Infotexts.Displayed);

            Assert.IsTrue(locationMenu.Terminals.Displayed);
            Assert.IsTrue(locationMenu.TerminalCreate.Displayed);
        }

        public void ContactMenuCheck(ContactMenu contactMenu)
        {
            Assert.IsTrue(contactMenu.Contact.Displayed);
            Assert.IsTrue(contactMenu.ContactEdit.Displayed);
        }

        public void LobbyMenu(LobbyMenu lobbyMenu)
        {
            Assert.IsTrue(lobbyMenu.Lobby.Displayed);
            Assert.IsTrue(lobbyMenu.Customer.CustomerCreate.Displayed);
            Assert.IsTrue(lobbyMenu.MassMutation.CustomerCreate.Displayed);
            Assert.IsTrue(lobbyMenu.MassMutation.LocationCreate.Displayed);
            Assert.IsTrue(lobbyMenu.MassMutation.TerminalCreate.Displayed);
            Assert.IsTrue(lobbyMenu.MassMutation.ContractCreate.Displayed);
            Assert.IsTrue(lobbyMenu.MassMutation.BusinessTemplateMigrate.Displayed);
            Assert.IsTrue(lobbyMenu.Ticket.My.Displayed);
            Assert.IsTrue(lobbyMenu.Ticket.MyGroup.Displayed);
            Assert.IsTrue(lobbyMenu.Ticket.NotAssigned.Displayed);
        }
    }
}
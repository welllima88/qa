using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu
{
    [TestClass]
    public class MenusTest
    {
        private static CustomerMenu _customerMenu;
        private static LocationMenu _locationMenu;
        private static TerminalMenu _terminalMenu;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _customerMenu = new CustomerMenu();
            _locationMenu = new LocationMenu();
            _terminalMenu = new TerminalMenu();
        }

        [TestMethod]
        public void CustomerMenuTest()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=85036");
            CustomerMenuCheck(_customerMenu);
        }

        [TestMethod]
        public void LocationMenuTest()
        {
            TestLauncher.Navigate("/Location/?LocationId=13404719-47a4-4686-8e22-161d3cd9903e");
            LocationMenuCheck(_locationMenu);
            _customerMenu.Customer.Click();
            CustomerMenuCheck(_customerMenu);
        }

        [TestMethod]
        public void TerminalMenuTest()
        {
            TestLauncher.Navigate(
                "/Pages/Terminal/TerminalView.aspx?PageMode=view&CustomerId=400805&TerminalId=30980051");

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
            Assert.IsTrue(terminalMenu.Deactivate.Displayed);
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

        // change to a more generic solution (list of elements <testobj>)
        public void CustomerMenuCheck(CustomerMenu customerMenu)
        {
            Assert.IsTrue(customerMenu.CustomerCreate.Displayed);
            Assert.IsTrue(customerMenu.CustomerEdit.Displayed);
            Assert.IsTrue(customerMenu.CustomerDeactivate.Displayed);
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
    }
}
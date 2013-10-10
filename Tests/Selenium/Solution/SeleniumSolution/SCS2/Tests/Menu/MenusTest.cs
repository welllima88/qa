using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.Tests.Menu
{
    [TestClass]
    public class MenusTest
    {
        [TestMethod]
        public void CustomerMenuTest()
        {
            TestLauncher.Navigate("/Pages/Customer/CustomerEdit.aspx?CustomerId=85036");
            CustomerMenuCheck();
        }

        [TestMethod]
        public void LocationMenuTest()
        {
            TestLauncher.Navigate("/Location/?LocationId=13404719-47a4-4686-8e22-161d3cd9903e");
            LocationMenuCheck();
            CustomerMenu.Customer.Click();
            CustomerMenuCheck();
        }

        [TestMethod]
        public void TerminalMenuTest()
        {
            TestLauncher.Navigate(
                "/Pages/Terminal/TerminalView.aspx?PageMode=view&CustomerId=400805&TerminalId=30980051");

            //CustomerMenuCheck(CustomerMenu);

            //// depending, where the terminal is created a location menu is displayed
            //if (LocationMenu.Location.Displayed)
            //{
            //    LocationMenuCheck(LocationMenu);
            //}
        }

        // change to a more generic solution (list of elements <testobj>)
        public static void CustomerMenuCheck()
        {
            Assert.IsTrue(CustomerMenu.CustomerCreate.Displayed);
            Assert.IsTrue(CustomerMenu.CustomerEdit.Displayed);
            Assert.IsTrue(CustomerMenu.CustomerDeactivate.Displayed);
            Assert.IsTrue(CustomerMenu.Customer.Displayed);

            Assert.IsTrue(CustomerMenu.LocationsOfCustomer.Displayed);
            Assert.IsTrue(CustomerMenu.LocationCreate.Displayed);

            Assert.IsTrue(CustomerMenu.BillingAdresses.Displayed);
            Assert.IsTrue(CustomerMenu.BillingAdressCreate.Displayed);

            Assert.IsTrue(CustomerMenu.Tickets.Displayed);

            Assert.IsTrue(CustomerMenu.Contacts.Displayed);
            Assert.IsTrue(CustomerMenu.ContactCreate.Displayed);

            Assert.IsTrue(CustomerMenu.Users.Displayed);
            Assert.IsTrue(CustomerMenu.UserCreate.Displayed);

            Assert.IsTrue(CustomerMenu.TerminalCreate.Displayed);
            Assert.IsTrue(CustomerMenu.TerminalsOfCustomerLocation.Displayed);
            Assert.IsTrue(CustomerMenu.TerminalsOfCustomerLocation.Displayed);
        }

        public static void LocationMenuCheck()
        {
            Assert.IsTrue(LocationMenu.Location.Displayed);
            Assert.IsTrue(LocationMenu.LocationEdit.Displayed);
            Assert.IsTrue(LocationMenu.LocationQuit.Displayed);

            Assert.IsTrue(LocationMenu.Contacts.Displayed);
            Assert.IsTrue(LocationMenu.ContactCreate.Displayed);

            Assert.IsTrue(LocationMenu.InfotextCreate.Displayed);
            Assert.IsTrue(LocationMenu.Infotexts.Displayed);

            Assert.IsTrue(LocationMenu.Terminals.Displayed);
            Assert.IsTrue(LocationMenu.TerminalCreate.Displayed);
        }

        public static void ContactMenuCheck()
        {
            Assert.IsTrue(ContactMenu.Contact.Displayed);
            Assert.IsTrue(ContactMenu.ContactEdit.Displayed);
        }
    }
}
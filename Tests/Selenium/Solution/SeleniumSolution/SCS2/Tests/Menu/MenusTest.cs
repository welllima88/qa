using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu;
using Six.Scs.Tests.Selenium.Extension.WebDriver;

namespace Six.Scs.Tests.Selenium.Tests.Menu
{
    [TestClass]
    public class MenusTest
    {
        [TestMethod]
        public void CustomerMenuTest()
        {
            TestDirector.Navigate("Pages/Customer/CustomerEdit.aspx?CustomerId=401858");
            CustomerMenuCheck();
        }

        [TestMethod]
        public void LocationMenuTest()
        {
            TestDirector.Navigate("Location?LocationId=071b90c2-c8c5-42c5-87c5-d816b26b0a1a");
            LocationMenuCheck();
            CustomerMenu.Customer.Click();
            CustomerMenuCheck();
        }

        [TestMethod]
        public void TerminalMenuTest()
        {
            TestDirector.Navigate(
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

            Assert.IsTrue(LocationMenu.CreateInfotext.Displayed);
            Assert.IsTrue(LocationMenu.Infotexts.Displayed);

            Assert.IsTrue(LocationMenu.Terminals.Displayed);
            Assert.IsTrue(LocationMenu.TerminalCreate.Displayed);
        }

        public static void ContactMenuCheck()
        {
            Assert.IsTrue(ContactMenu.Contact.Displayed);
            Assert.IsTrue(ContactMenu.ContactEdit.Displayed);
        }

        public static void UserMenuCheck()
        {
            Assert.IsTrue(UserMenu.New.Displayed);
            Assert.IsTrue(UserMenu.Edit.Displayed);
            Assert.IsTrue(UserMenu.Feedback.Displayed);
            Assert.IsTrue(UserMenu.Service.Displayed);
            Assert.IsTrue(UserMenu.Roles.Displayed);
            Assert.IsTrue(UserMenu.ResetPassword.Displayed);
        }
    }
}
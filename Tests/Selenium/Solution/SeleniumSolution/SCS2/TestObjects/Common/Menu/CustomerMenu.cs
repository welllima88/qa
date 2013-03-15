using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class CustomerMenu : MenuObject
    {
        public CustomerMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement Customer
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Customer/CustomerEdit.aspx?CUSTOMERID=']")); }
        }

        public IWebElement CustomerCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Customer/CustomerEdit.aspx?PageMode=new']")); }
        }

        public IWebElement LocationCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Location/New?CUSTOMERID=']")); }
        }

        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/TerminalNew.aspx?CUSTOMERID=']")); }
        }

        public IWebElement UserCreate
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/LoginNew.asp?CUSTOMERID=']")); }
        }

        public IWebElement CustomerEdit
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='/Customer/CustomerEdit.aspx?PageMode=edit&CUSTOMERID=']"));
            }
        }

        public IWebElement CustomerQuit
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("a[href*='Customer/CustomerDeactivate.aspx?CUSTOMERID=']"));
            }
        }

        public IWebElement LocationsOfCustomer
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='Location/LocationList.aspx?CUSTOMERID=']"));
            }
        }

        public IWebElement TerminalsOfCustomerLocation
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='Terminal/TerminalList.aspx?CUSTOMERLOCATIONID=']"));
            }
        }

        public IWebElement AllTerminals
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("a[href*='Terminal/TerminalList.aspx?CUSTOMERID=']"));
            }
        }

        public IWebElement Tickets
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='TicketList.asp?ListType=customer&CUSTOMERID=']"));
            }
        }

        public IWebElement Users
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='User/UserList.aspx?CUSTOMERID=']"));
            }
        }

        public IWebElement Contacts
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='Person/PersonList.aspx?CUSTOMERID=']"));
            }
        }

        public IWebElement ContactCreate
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("a[href*='Person/PersonEdit.aspx?PageMode=new&CUSTOMERID=']"));
            }
        }

        public IWebElement BillingAdresses
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='BillingAddress/List?CUSTOMERID=']"));
            }
        }

        public IWebElement BillingAdressCreate
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector("a[href*='BillingAddress/New?CUSTOMERID=']"));
            }
        }

        public IWebElement BillingAddressEdit
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/BillingAddress/Edit?CUSTOMERID=']")); }
        }
    }
}
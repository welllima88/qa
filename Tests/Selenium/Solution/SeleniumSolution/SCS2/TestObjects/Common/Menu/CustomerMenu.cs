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
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_Customer)); }
        }

        public IWebElement CustomerCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_CustomerCreate)); }
        }

        public IWebElement LocationCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_LocationCreate)); }
        }

        public IWebElement TerminalCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_TerminalCreate)); }
        }

        public IWebElement UserCreate
        {
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_UserCreate)); }
        }

        public IWebElement CustomerEdit
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_CustomerEdit));
            }
        }

        public IWebElement CustomerDeactivate
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Menu.CustomerMenu_CustomerDeactivate));
            }
        }

        public IWebElement LocationsOfCustomer
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_LocationsOfCustomer));
            }
        }

        public IWebElement TerminalsOfCustomerLocation
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_TerminalsOfCustomerLocation));
            }
        }

        public IWebElement AllMpds
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Menu.CustomerMenu_AllMpds));
            }
        }

        public IWebElement AllTerminals
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Menu.CustomerMenu_AllTerminals));
            }
        }

        public IWebElement Tickets
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Menu.CustomerMenu_Tickets));
            }
        }

        public IWebElement Users
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_Users));
            }
        }

        public IWebElement Contacts
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_Contacts));
            }
        }

        public IWebElement ContactCreate
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector(Menu.CustomerMenu_ContactCreate));
            }
        }

        public IWebElement BillingAdresses
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_BillingAdresses));
            }
        }

        public IWebElement BillingAdressCreate
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(Menu.CustomerMenu_BillingAdressCreate));
            }
        }

        public IWebElement BillingAddressEdit
        {
            get { return Driver.FindElement(By.CssSelector(Menu.CustomerMenu_BillingAddressEdit)); }
        }
    }
}
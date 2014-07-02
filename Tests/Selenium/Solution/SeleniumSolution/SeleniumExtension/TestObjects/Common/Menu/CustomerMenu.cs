using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class CustomerMenu : WebObject
    {
        public static IWebElement Customer
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_Customer)); }
        }

        public static IWebElement CustomerCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_CustomerCreate)); }
        }

        public static IWebElement LocationCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_LocationCreate)); }
        }

        public static IWebElement TerminalCreate
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_TerminalCreate)); }
        }

        public static IWebElement CustomerEdit
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_CustomerEdit));
            }
        }

        public static IWebElement CustomerDeactivate
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_CustomerDeactivate));
            }
        }

        public static IWebElement LocationsOfCustomer
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_LocationsOfCustomer));
            }
        }

        public static IWebElement TerminalsOfCustomerLocation
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_TerminalsOfCustomerLocation));
            }
        }

        public static IWebElement AllMpds
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_AllMpds));
            }
        }

        public static IWebElement AllTerminals
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_AllTerminals));
            }
        }

        public static IWebElement Tickets
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_Tickets));
            }
        }

        public static IWebElement Users
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_Users));
            }
        }

        public static IWebElement Contacts
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_Contacts));
            }
        }

        public static IWebElement ContactCreate
        {
            get
            {
                return
                    WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_ContactCreate));
            }
        }

        public static IWebElement BillingAdresses
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_BillingAdresses));
            }
        }

        public static IWebElement BillingAdressCreate
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.CssSelector(MenuRes.CustomerMenu_BillingAdressCreate));
            }
        }

        public static IWebElement BillingAddressEdit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_BillingAddressEdit)); }
        }

        public static IWebElement Infotexts
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_Infotexts)); }
        }

        public static IWebElement CreateInfotext
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.CustomerMenu_InfotextCreate)); }
        }
    }
}
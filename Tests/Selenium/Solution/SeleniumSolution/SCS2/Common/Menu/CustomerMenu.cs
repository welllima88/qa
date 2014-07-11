using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class CustomerMenu : WebObject
    {
        public static IWebElementAdapter Customer
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_Customer)); }
        }

        public static IWebElementAdapter CustomerCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_CustomerCreate)); }
        }

        public static IWebElementAdapter LocationCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_LocationCreate)); }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_TerminalCreate)); }
        }

        public static IWebElementAdapter CustomerEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_CustomerEdit));
            }
        }

        public static IWebElementAdapter CustomerDeactivate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_CustomerDeactivate));
            }
        }

        public static IWebElementAdapter LocationsOfCustomer
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_LocationsOfCustomer));
            }
        }

        public static IWebElementAdapter TerminalsOfCustomerLocation
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_TerminalsOfCustomerLocation));
            }
        }

        public static IWebElementAdapter AllMpds
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_AllMpds));
            }
        }

        public static IWebElementAdapter AllTerminals
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_AllTerminals));
            }
        }

        public static IWebElementAdapter Tickets
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_Tickets));
            }
        }

        public static IWebElementAdapter Users
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_Users));
            }
        }

        public static IWebElementAdapter Contacts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_Contacts));
            }
        }

        public static IWebElementAdapter ContactCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_ContactCreate));
            }
        }

        public static IWebElementAdapter BillingAdresses
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_BillingAdresses));
            }
        }

        public static IWebElementAdapter BillingAdressCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(MenuRes.CustomerMenu_BillingAdressCreate));
            }
        }

        public static IWebElementAdapter BillingAddressEdit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_BillingAddressEdit)); }
        }

        public static IWebElementAdapter Infotexts
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_Infotexts)); }
        }

        public static IWebElementAdapter CreateInfotext
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.CustomerMenu_InfotextCreate)); }
        }
    }
}
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Common.Menu
{
    public class CustomerMenu : WebObject
    {
        public static IWebElement Customer
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Customer/?CUSTOMERID=']"));
            }
        }

        public static IWebElement CustomerCreate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Customer/NewStep1/']"));
            }
        }

        public static IWebElement LocationCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Location/New?CUSTOMERID=']"));
            }
        }

        public static IWebElement LocationsOfCustomer
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Location/LocationList.aspx?CUSTOMERID=']"));
            }
        }

        public static IWebElement TerminalsOfCustomerLocation
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Terminal/TerminalList.aspx?CUSTOMERLOCATIONID=']"));
            }
        }

        public static IWebElement AllMpds
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Mpd/ListByCustomer/?CUSTOMERID=']"));
            }
        }

        public static IWebElement AllTerminals
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Customer/TerminalListAll?CUSTOMERID=']"));
            }
        }

        public static IWebElement Tickets
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='TicketList.asp?ListType=customer&CUSTOMERID=']"));
            }
        }

        public static IWebElement Users
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/User/List/?CUSTOMERID=']"));
            }
        }

        public static IWebElement Contacts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Person/CustomerPersonList?CUSTOMERID=']"));
            }
        }

        public static IWebElement BillingAdresses
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='BillingAddress/List?CUSTOMERID=']"));
            }
        }

        public static IWebElement BillingAddressEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/BillingAddress/Edit?CUSTOMERID=']"));
            }
        }

        public static IWebElement CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/CustomerInfoText/Create?&CUSTOMERID=']"));
            }
        }
    }
}
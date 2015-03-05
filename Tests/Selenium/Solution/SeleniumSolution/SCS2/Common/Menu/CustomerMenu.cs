using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class CustomerMenu : WebObject
    {
        public static IWebElementAdapter Customer
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Customer/?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter CustomerCreate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Customer/NewStep1/']"));
            }
        }

        public static IWebElementAdapter LocationCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Location/New?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter TerminalCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector(
                            "td#leftHandMenu a[href*='/TerminalArticleSelector/CustomerTerminalNew/?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter CustomerEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/Customer/Edit/?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter CustomerDeactivate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Customer/CustomerDeactivate.aspx?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter LocationsOfCustomer
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Location/LocationList.aspx?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter TerminalsOfCustomerLocation
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='Terminal/TerminalList.aspx?CUSTOMERLOCATIONID=']"));
            }
        }

        public static IWebElementAdapter AllMpds
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Mpd/ListByCustomer/?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter AllTerminals
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Customer/TerminalListAll?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter Tickets
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='TicketList.asp?ListType=customer&CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter Users
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("td#leftHandMenu a[href*='/User/List/?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter Contacts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Person/CustomerPersonList?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter ContactCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/Person/CustomerPersonNew?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter BillingAdresses
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='BillingAddress/List?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter BillingAdressCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='BillingAddress/New?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter BillingAddressEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/BillingAddress/Edit?CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter Infotexts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("td#leftHandMenu a[href*='/InfoText/ListCustomer?&CUSTOMERID=']"));
            }
        }

        public static IWebElementAdapter CreateInfotext
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
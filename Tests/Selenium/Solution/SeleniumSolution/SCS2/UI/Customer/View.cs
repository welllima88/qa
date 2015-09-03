using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Customer
{
    public class View : WebObject
    {
        public static IWebElement MoveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("move")); }
        }

        public static IWebElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")); }
        }

        public static IWebElement EditDefaultConfigButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerDefaultEdit")); }
        }

        public static string CustomerName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerName")).Text; }
        }

        public static string CashIntegrator
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CashIntegrator")).Text; }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_CompanyName")).Text; }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SapNumber")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Street")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Zip")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("City")).Text; }
        }

        public static string Agency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Language")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Country")).Text; }
        }

        public static string Po
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Po")).Text; }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AddressAddition")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("EMail")).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Telephone")).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Mobile")).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Fax")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Web")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Region")).Text; }
        }

        public static string CategoryCode
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CategoryCode")).Text; }
        }

        public static string SupportContract
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SupportContract")).Text; }
        }

        public static string Segment
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSSegment")).Text; }
        }

        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SupplierMandant")).Text; }
        }

        public static string SbsBillingTenant
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSBillingTenant")).Text; }
        }

        public static string SbsCurrency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSCurrency")).Text; }
        }

        public static string CustomerNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerId")).Text; }
        }

        public static string SbsDebitNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSDebitNumber")).Text; }
        }

        public static string SbsAdressNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSAddressNumber")).Text; }
        }

        public static IWebElement ContactCreate
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("a[href*='/Person/CustomerPersonNew?CustomerId=']"));
            }
        }

        public static IWebElement CustomerEdit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/scs2/Customer/Edit?customerId=']"));
            }
        }

        public static IWebElement CreateInfotext
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("a[href*='/InfoText/NewCustomerInfoText?customerId=']"));
            }
        }

        public static IWebElement Quit
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(
                        By.CssSelector("a#resign[href*='/Customer/Resign?customerId=']"));
            }
        }

        public static IWebElement ConfirmQuit
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#resign")); }
        }

        public static bool IsCanceled
        {
            get { return WebDriver.FindElements(By.CssSelector("td#content>div.canceled")).Count > 0; }
        }

        public static IWebElement Activate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a#activate[href*='/Customer/Activate?customerId=']"));
            }
        }

        public static IWebElement ConfirmActivate
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#activate")); }
        }

        public static IEnumerable<string> Infotexts
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(By.CssSelector("div#infotext div.panel-body div.row"))
                        .Select(e => e.Text).ToList();
            }
        }
    }
}
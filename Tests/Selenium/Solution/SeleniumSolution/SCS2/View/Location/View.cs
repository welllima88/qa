using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Location
{
    public class View : WebObject
    {
        public static ButtonElement EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")).Button(); }
        }

        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationName")).Text; }
        }

        public static string LocationNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationNumber")).Text; }
        }

        public static string Guid
        {
            get { return WebDriver.FindAdaptedElement(By.Id("GUID")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("StreetNo")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Zip")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("City")).Text; }
        }

        public static string SbsDebitNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSDebitNumber")).Text; }
        }

        public static string SbsAdressNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SBSAddressNumber")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Language")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Country")).Text; }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Ep2MerchantId")).Text; }
        }

        public static string SapNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("SapNumber")).Text; }
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
            get { return WebDriver.FindAdaptedElement(By.Id("Email")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Web")).Text; }
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

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Region")).Text; }
        }

        public static string Agency
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Agency")).Text; }
        }

        public static IWebElement ContactCreate
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/Person/New?locationId=']"));
            }
        }
        public static IWebElement Infotexts
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("a[href*='/InfoText/NewLocationInfoText?locationId=']"));
            }
        }
        public static bool IsCanceled
        {
            get { return WebDriver.FindElements(By.CssSelector("td#content>div.canceled")).Count > 0; }
        }
    }
}
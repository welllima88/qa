using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Location.BillingAddress
{
    public class View : WebObject
    {
        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("BillingName")).Text; }
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

        public static IWebElementAdapter EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")); }
        }

        public static string SbsDebitNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("DebitNbr")).Text; }
        }

        public static string SbsAddressNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AddressNbr")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Region")).Text; }
        }

        public static IWebElementAdapter List(Model.ValueObjects.BillingAddress billingAddress)
        {
            return
                WebDriver.FindAdaptedElements(By.Id("td#content table>tbody>tr>td>a"))
                    .FirstOrDefault(ba => ba.Text.Contains(billingAddress.CompanyName));
        }
    }
}
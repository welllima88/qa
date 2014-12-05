using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location.BillingAddress
{
    public class View : WebObject
    {
        public static string CompanyName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_LocationName")).Text; }
        }

        public static string StreetName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Street")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_ZIP")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_City")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_LanguageId")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_CountryId")).Text; }
        }

        public static string Po
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_PO")).Text; }
        }

        public static string AdressAddition
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_AddressAddition")).Text; }
        }

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Email")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Web")).Text; }
        }

        public static string Telephone
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Telephone")).Text; }
        }

        public static string Mobile
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Mobile")).Text; }
        }

        public static string Fax
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_Fax")).Text; }
        }

        public static IWebElementAdapter EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ctl00_bodyContentPlaceHolder_btnEdit")); }
        }

        public static string SbsDebitNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("DebitNbr")).Text; }
        }

        public static string SbsAddressNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AddressNbr")).Text; }
        }
    }
}
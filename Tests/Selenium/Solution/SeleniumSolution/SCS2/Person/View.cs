using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Person
{
    public class View : WebObject
    {
        public static IWebElementAdapter EditButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("edit")); }
        }

        public static string AddressAddition
        {
            get { return WebDriver.FindAdaptedElement(By.Id("AddressAddition")).Text; }
        }

        public static string FirstName
        {
            get { return WebDriver.FindAdaptedElement(By.Id("FirstName")).Text; }
        }

        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LastName")).Text; }
        }

        public static string Salutation
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Salutation")).Text; }
        }

        public static string Country
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Country")).Text; }
        }

        public static string Language
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Language")).Text; }
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

        public static string Email
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Email")).Text; }
        }

        public static string Web
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Web")).Text; }
        }

        public static string StreetNo
        {
            get { return WebDriver.FindAdaptedElement(By.Id("StreetNo")).Text; }
        }

        public static string Po
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Po")).Text; }
        }

        public static string Zip
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Zip")).Text; }
        }

        public static string City
        {
            get { return WebDriver.FindAdaptedElement(By.Id("City")).Text; }
        }

        public static string Region
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Region")).Text; }
        }

        public static IWebElementAdapter DeleteButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("delete")); }
        }

        public static IWebElementAdapter CreateUser
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CreateUser")); }
        }

        public static string Id
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content h1")).GetAttribute("id"); }
        }

        public static void DeleteConfirm()
        {
            // WebDriver.SwitchTo().Alert().Accept();
            WebDriver.FindAdaptedElement(By.CssSelector("div.modal-content button[type='submit']")).Click();
        }
    }
}
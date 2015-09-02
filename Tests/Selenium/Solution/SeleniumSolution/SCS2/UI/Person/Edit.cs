using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Person
{
    public class Edit : WebObject
    {
        public static IWebElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#cancel")); }
        }

        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static IWebElement ClickAdressFromLocation
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#defaultAdress")); }
        }

        public static string FirstName
        {
            set { Create.FirstName = value; }
            get { return Create.FirstName; }
        }

        public static string Name
        {
            set { Create.Name = value; }
            get { return Create.Name; }
        }

        public static string Salutation
        {
            set { Create.Salutation = value; }
            get { return Create.Salutation; }
        }

        public static string Country
        {
            set { Create.Country = value; }
            get { return Create.Country; }
        }

        public static string Language
        {
            set { Create.Language = value; }
            get { return Create.Language; }
        }

        public static string Telephone
        {
            set { Create.Telephone = value; }
            get { return Create.Telephone; }
        }

        public static string Mobile
        {
            set { Create.Mobile = value; }
            get { return Create.Mobile; }
        }

        public static string Fax
        {
            set { Create.Fax = value; }
            get { return Create.Fax; }
        }

        public static string Email
        {
            set { Create.Email = value; }
            get { return Create.Email; }
        }

        public static string Web
        {
            set { Create.Web = value; }
            get { return Create.Web; }
        }

        public static string StreetNo
        {
            set { Create.StreetNo = value; }
            get { return Create.StreetNo; }
        }

        public static string Po
        {
            set { Create.Po = value; }
            get { return Create.Po; }
        }

        public static string Zip
        {
            set { Create.Zip = value; }
            get { return Create.Zip; }
        }

        public static string City
        {
            set { Create.City = value; }
            get { return Create.City; }
        }

        public static string Region
        {
            set { Create.Region = value; }
            get { return Create.Region; }
        }

        public static string AdressAddition
        {
            set { Create.AdressAddition = value; }
            get { return Create.AdressAddition; }
        }
    }
}
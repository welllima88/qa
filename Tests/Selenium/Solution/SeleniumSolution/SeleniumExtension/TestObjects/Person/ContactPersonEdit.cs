using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Person
{
    public class ContactPersonEdit : WebObject
    {
        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("button#cancel")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#save")); }
        }

        //TODO test this explicit! because in edit mode not available
        public IWebElement ClickAdressFromLocation
        {
            get { return WebDriver.FindElement(By.CssSelector("button#defaultAdress")); }
        }

        public static string FirstName
        {
            set { ContactPersonCreate.FirstName = value; }
            get { return ContactPersonCreate.FirstName; }
        }

        public static string Name
        {
            set { ContactPersonCreate.Name = value; }
            get { return ContactPersonCreate.Name; }
        }

        public static string Salutation
        {
            set { ContactPersonCreate.Salutation = value; }
            get { return ContactPersonCreate.Salutation; }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonEditRes.Country)).Selector().SelectByValue(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonEditRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public static string Language
        {
            set { ContactPersonCreate.Language = value; }
            get { return ContactPersonCreate.Language; }
        }

        public static string Telephone
        {
            set { ContactPersonCreate.Telephone = value; }
            get { return ContactPersonCreate.Telephone; }
        }

        public static string Mobile
        {
            set { ContactPersonCreate.Mobile = value; }
            get { return ContactPersonCreate.Mobile; }
        }

        public static string Fax
        {
            set { ContactPersonCreate.Fax = value; }
            get { return ContactPersonCreate.Fax; }
        }

        public static string Email
        {
            set { ContactPersonCreate.Email = value; }
            get { return ContactPersonCreate.Email; }
        }

        public static string Web
        {
            set { ContactPersonCreate.Web = value; }
            get { return ContactPersonCreate.Web; }
        }

        public static string StreetNo
        {
            set { ContactPersonCreate.StreetNo = value; }
            get { return ContactPersonCreate.StreetNo; }
        }

        public static string Po
        {
            set { ContactPersonCreate.Po = value; }
            get { return ContactPersonCreate.Po; }
        }

        public static string Zip
        {
            set { ContactPersonCreate.Zip = value; }
            get { return ContactPersonCreate.Zip; }
        }

        public static string City
        {
            set { ContactPersonCreate.City = value; }
            get { return ContactPersonCreate.City; }
        }

        public static string Region
        {
            set { ContactPersonCreate.Region = value; }
            get { return ContactPersonCreate.Region; }
        }

        public static string AdressAddition
        {
            set { ContactPersonCreate.AddressAddition = value; }
            get { return ContactPersonCreate.AddressAddition; }
        }
    }
}
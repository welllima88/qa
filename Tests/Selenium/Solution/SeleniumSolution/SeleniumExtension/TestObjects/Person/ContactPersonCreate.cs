using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Person
{
    public class ContactPersonCreate : WebObject
    {
        #region IContactCreate Members

        public static string AddressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.AddressAddition)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.AddressAddition)).Text; }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string CreateDate { get; private set; }

        public static string FirstName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).Text; }
        }

        public static string Name
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).Text; }
        }

        public static string Salutation
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).Text; }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonCreateRes.Country)).Selector().SelectByValue(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(
                    PersonCreateRes.Country)).Selector().SelectedOption.Text;
            }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        PersonCreateRes.Language)).Selector().SelectByValue(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(
                        PersonCreateRes.Language)).Selector().SelectedOption.Text;
            }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Telephone)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Telephone)).Text; }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Mobile)).TextBox().TypeText(
                    value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Mobile)).Text; }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Fax)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Fax)).Text; }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Email)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Email)).Text; }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Web)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Web)).Text; }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Street)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Street)).Text; }
        }

        public string AdressAddition { get; set; }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Po)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Po)).Text; }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Zip)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Zip)).Text; }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.City)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.City)).Text; }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Region)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Region)).Text; }
        }

        #endregion
    }
}
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Person
{
    public class ContactPersonCreate : WebObject
    {
        public static string AddressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#addition")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#addition")).TextBox().Text(); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string FirstName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TextBox().Text(); }
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
                WebDriver.FindAdaptedElement(By.CssSelector("select#ccc"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#ccc"))
                             .Selector()
                             .SelectedOption.Text;
            }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_LanguageId"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_LanguageId"))
                             .Selector()
                             .SelectedOption.Text;
            }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#telephone")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#telephone")).TextBox().Text(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#mobile")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#mobile")).TextBox().Text(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#fax")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#fax")).TextBox().Text(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#email")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#email")).TextBox().Text(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#web")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#web")).TextBox().Text(); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#street")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#street")).TextBox().Text(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#po")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#po")).TextBox().Text(); }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#zip")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#zip")).TextBox().Text(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#city")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#city")).TextBox().Text(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#region")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#region")).TextBox().Text(); }
        }
    }
}
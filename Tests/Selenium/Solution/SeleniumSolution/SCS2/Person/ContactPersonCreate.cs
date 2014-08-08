using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Person
{
    public class ContactPersonCreate : WebObject
    {
        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#addition")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#addition")).TextField().Text(); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static ButtonElement AdressFromLocation
        {
            get { return WebDriver.FindAdaptedElement(By.Id("defaultAdress")).Button(); }
        }

        public static string FirstName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.FirstName)).TextField().Text(); }
        }

        public static string Name
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Name)).Text; }
        }

        public static string Salutation
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).TextField().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(PersonCreateRes.Salutation)).Text; }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#ccc"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#ccc"))
                        .Selector()
                        .SelectedOption;
            }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_LanguageId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_LanguageId"))
                        .Selector()
                        .SelectedOption;
            }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#telephone")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#telephone")).TextField().Text(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#mobile")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#mobile")).TextField().Text(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#fax")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#fax")).TextField().Text(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#email")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#email")).TextField().Text(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#web")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#web")).TextField().Text(); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#street")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#street")).TextField().Text(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#po")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#po")).TextField().Text(); }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#zip")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#zip")).TextField().Text(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#city")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#city")).TextField().Text(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#region")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#region")).TextField().Text(); }
        }
    }
}
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Person
{
    public class Create : WebObject
    {
        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Addition"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Addition")).TextField().Text();
            }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")); }
        }

        public static ButtonElement AdressFromLocation
        {
            get { return WebDriver.FindAdaptedElement(By.Id("defaultAdress")).Button(); }
        }

        public static string FirstName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_FirstName")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_FirstName")).TextField().Text();
            }
        }

        public static string Name
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_LastName")).TextField().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_LastName")).Text; }
        }

        public static string Salutation
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Salutation")).TextField().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("PersonData_Salutation")).Text; }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_CountryId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#PersonData_Contact_CountryId"))
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
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Telephone"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Telephone"))
                        .TextField()
                        .Text();
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Mobile"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Mobile")).TextField().Text();
            }
        }

        public static string Fax
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Fax")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Fax")).TextField().Text();
            }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Email"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Email")).TextField().Text();
            }
        }

        public static string Web
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Web")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Web")).TextField().Text();
            }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Street"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Street")).TextField().Text();
            }
        }

        public static string Po
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_PO")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_PO")).TextField().Text();
            }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_ZIP")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_ZIP")).TextField().Text();
            }
        }

        public static string City
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_City")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_City")).TextField().Text();
            }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Region"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#PersonData_Contact_Region")).TextField().Text();
            }
        }
    }
}
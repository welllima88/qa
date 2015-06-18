using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Location.BillingAddress
{
    public class Create : WebObject
    {
        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("Address_CountryId")).Selector().SelectByText(value);
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Zip")).TextField().TypeText(value); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_City")).TextField().TypeText(value); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.Id("Addition")).TextField().TypeText(value); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_POBox")).TextField().TypeText(value); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Region")).TextField().TypeText(value); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Phone")).TextField().TypeText(value); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Mobile")).TextField().TypeText(value); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Fax")).TextField().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Email")).TextField().TypeText(value); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.Id("CompanyName")).TextField().TypeText(value); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Street")).TextField().TypeText(value); }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("Address_LanguageId")).Selector().SelectByText(value);
            }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.Id("Address_Web")).TextField().TypeText(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}
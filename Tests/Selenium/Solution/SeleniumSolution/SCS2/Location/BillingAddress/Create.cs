using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location.BillingAddress
{
    public class Create : WebObject
    {
        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_CountryId")).Selector().SelectByText(value);
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_ZIP")).TextField().TypeText(value); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_City")).TextField().TypeText(value); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Addition")).TextField().TypeText(value); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_PO")).TextField().TypeText(value); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Region")).TextField().TypeText(value); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Telephone")).TextField().TypeText(value); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Mobile")).TextField().TypeText(value); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Fax")).TextField().TypeText(value); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Email")).TextField().TypeText(value); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Name")).TextField().TypeText(value); }
        }

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Street")).TextField().TypeText(value); }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_LanguageId")).Selector().SelectByText(value);
            }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.Id("BillingAddress_Address_Web")).TextField().TypeText(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}
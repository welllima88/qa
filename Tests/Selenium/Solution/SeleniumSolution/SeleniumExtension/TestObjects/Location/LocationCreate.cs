using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Location
{
    public class LocationCreate : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input.button[type='submit']")); }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_CountryId"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_CountryId")).Selector().
                              SelectedOption.Text;
            }
        }

        public string Ep2MerchantId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Ep2MerchantId"))
                         .TextBox()
                         .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Ep2MerchantId")).TextBox().Text(); }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_LanguageId"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_LanguageId")).Selector().
                              SelectedOption.Text;
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_ZIP")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_ZIP")).TextBox().Text(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_City")).TextBox().TypeText(value); }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Addition"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_PO")).TextBox().TypeText(value); }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Region"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Telephone"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Mobile"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Fax")).TextBox().TypeText(value); }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Email"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_SapNumber")).TextBox().TypeText(value); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Name")).TextBox().TypeText(value); }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Street"))
                         .TextBox()
                         .TypeText(value);
            }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Web")).TextBox().TypeText(value); }
        }
    }
}
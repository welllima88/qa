using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Location
{
    public class Create : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")).Button(); }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_CountryId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_CountryId")).Selector().
                        SelectedOption;
            }
        }

        public static string Ep2MerchantId
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Ep2MerchantId"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Ep2MerchantId")).TextField().Text();
            }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_LanguageId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#LocationData_Address_LanguageId")).Selector().
                        SelectedOption;
            }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_ZIP"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_ZIP")).TextField().Text();
            }
        }

        public static string City
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_City"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Addition"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Po
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_PO")).TextField().TypeText(value);
            }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Region"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Telephone"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Mobile"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Fax
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Fax"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Email"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string SapNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_SapNumber")).TextField().TypeText(value);
            }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Name")).TextField().TypeText(value); }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Street"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string Web
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#LocationData_Address_Web"))
                    .TextField()
                    .TypeText(value);
            }
        }
    }
}
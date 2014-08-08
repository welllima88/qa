using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Customer
{
    public class CustomerEdit : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static ButtonElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#cancel")).Button(); }
        }

        public static string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextField().Text(); }
        }

        public static string SapNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextField().Text();
            }
        }

        public static string CompanyName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).TextField().Text();
            }
        }

        public static string Supplier
        {
            get { return WebDriver.FindAdaptedElement(By.Id("LocationData_LocationGUID")).Text; }
        }

        public static String CustomerNumber
        {
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_CustomerId")).Text; }
        }

        public static String Ep2MerchantId
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId")).TextField().Text();
            }
        }

        public static string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_AgencyId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_AgencyId"))
                        .Selector()
                        .SelectedOption;
            }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street")).TextField().Text();
            }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_LanguageId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_LanguageId"))
                        .Selector()
                        .SelectedOption;
            }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                        .Selector()
                        .SelectedOption;
            }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).TextField().Text();
            }
        }

        public static string City
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).TextField().Text();
            }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                        .TextField()
                        .Text();
            }
        }

        public static string Po
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextField().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextField().Text();
            }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region")).TextField().Text();
            }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone"))
                        .TextField()
                        .Text();
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile")).TextField().Text();
            }
        }

        public static string Fax
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).TextField().Text();
            }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email")).TextField().Text();
            }
        }

        public static string Web
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web"))
                    .TextField()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web")).TextField().Text();
            }
        }
    }
}
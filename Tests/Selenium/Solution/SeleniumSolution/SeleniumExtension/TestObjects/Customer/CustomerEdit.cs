using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Customer
{
    public class CustomerEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")); }
        }

        public static IWebElement CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#cancel")); }
        }

        public static string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextBox().Text(); }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextBox().Text(); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).TextBox().Text(); }
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
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId")).TextBox().Text(); }
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
                             .SelectedOption.Text;
            }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street"))
                         .TextBox()
                         .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street")).TextBox().Text(); }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_LanguageId"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_LanguageId"))
                             .Selector()
                             .SelectedOption.Text;
            }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                         .Selector()
                         .SelectByValue(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                             .Selector()
                             .SelectedOption.Text;
            }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).TextBox().Text(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).TextBox().Text(); }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                         .TextBox()
                         .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition")).TextBox().Text();
            }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextBox().Text(); }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region"))
                         .TextBox()
                         .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region")).TextBox().Text(); }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone"))
                         .TextBox()
                         .TypeText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone"))
                             .TextBox()
                             .Text();
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile"))
                         .TextBox()
                         .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile")).TextBox().Text(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).TextBox().Text(); }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email"))
                         .TextBox()
                         .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email")).TextBox().Text(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web")).TextBox().Text(); }
        }
    }
}
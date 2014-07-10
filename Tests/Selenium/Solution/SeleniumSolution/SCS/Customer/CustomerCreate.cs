using System;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Customer
{
    public class CustomerCreate : WebObject
    {
        public static string Segment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#CustomerSegment")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Strasse']")).TextField().TypeText(value); }
        }

        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='abbrechen']")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='weiter']")); }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='CountryId']"))
                         .Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string SbsBillingTenant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingTenant")).
                          Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string Ep2MerchantId
        {
            set { WebDriver.FindAdaptedElement(By.Id("CustomerData_Ep2MerchantId")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.Id("CustomerData_Ep2MerchantId")).GetCssValue("value"); }
        }

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='PLZ']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Ort']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Zusatz']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Postfach']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Region']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon2']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Fax']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Email']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Guid { get; set; }

        public static string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerName']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='SapNumber']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("td[name='Name']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#StructureId")).
                          Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string SbsAdressNumber
        {
            get { throw new NotImplementedException(); }
        }

        public static string SbsCurrency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#SBSCurrency")).Selector
                    ().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string CategoryCode
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='CategoryCode']")).Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='Agency']")).Selector
                    ().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='SupportContractId]'")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string StreetNo { get; set; }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='LanguageId]'")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='www']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string CashIntegrator
        {
            set { throw new NotSupportedException("CashIntegrator will be set separately"); }
            get { throw new NotImplementedException(); }
        }

        public static string CustomerNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerId']")).TextField().TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public static string SbsDebitNumber { get; private set; }
    }
}
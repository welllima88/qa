using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Customer
{
    public class CustomerCreate : WebObject, ICustomerCreate
    {
        public CustomerCreate(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string CustomerSegment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#CustomerSegment")).Selector().
                          SelectByText(value);
            }
        }

        #region ICustomerCreate Members

        public string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='CountryId']"))
                         .Selector().SelectByText(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingTenant")).
                          Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='PLZ']")).TypeText(value); }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Ort']")).TypeText(value); }
        }

        public string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Zusatz']")).TypeText(value); }
        }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Postfach']")).TypeText(value); }
        }

        public string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Region']")).TypeText(value); }
        }

        public string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon']")).TypeText(value); }
        }

        public string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon2']")).TypeText(value); }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Fax']")).TypeText(value); }
        }

        public string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Email']")).TypeText(value); }
        }

        public string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerName']")).TypeText(value); }
        }

        public string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='SapNumber']")).TypeText(value); }
        }

        public string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("td[name='Name']")).TypeText(value); }
        }


        public string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#StructureId")).
                          Selector().SelectByText(value);
            }
        }


        public string SbsCurrency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#SBSCurrency")).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='CategoryCode']")).Selector().SelectByText(value);
            }
        }

        public string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='Agency']")).Selector
                    ().SelectByText(value);
            }
        }

        public string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='SupportContractId]'")).Selector().
                          SelectByText(value);
            }
        }

        public string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Strasse']")).TypeText(value); }
        }

        public string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='LanguageId]'")).Selector().
                          SelectByText(value);
            }
        }

        public string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='www']")).TypeText(value); }
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='abbrechen']")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='weiter']")); }
        }

        public string CustomerNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerId']")).TypeText(value); }
        }

        public string CashIntegrator
        {
            set { throw new NotSupportedException("CashIntegrator will be set separately"); }
        }

        public string Segment
        {
            set { throw new NotImplementedException(); }
        }

        #endregion
    }
}
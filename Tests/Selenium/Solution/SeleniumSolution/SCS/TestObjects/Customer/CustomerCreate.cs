using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Customer
{
    public class CustomerCreate :WebObject, ICustomerCreate
    {
        public CustomerCreate(IWebDriverAdapter driver):base(driver)
        {            
        }

        #region ICustomerCreate Members

        public string Country
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("select[name='CountryId']"))
                    .Selector().SelectByText(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#BillingTenant")).
                    Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='PLZ']")).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Ort']")).TypeText(value); }
        }

        public string AdressAddition
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Zusatz']")).TypeText(value); }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Postfach']")).TypeText(value); }
        }

        public string Region
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Region']")).TypeText(value); }
        }

        public string Telephone
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Telefon']")).TypeText(value); }
        }

        public string Mobile
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Telefon2']")).TypeText(value); }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Fax']")).TypeText(value); }
        }

        public string Email
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Email']")).TypeText(value); }
        }

        public string CustomerName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='CustomerName']")).TypeText(value); }
        }

        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='SapNumber']")).TypeText(value); }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("td[name='Name']")).TypeText(value); }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#StructureId")).
                    Selector().SelectByText(value);
            }
        }


        public string SbsCurrency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#SBSCurrency")).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("select[name='CategoryCode']")).Selector().SelectByText(value);
            }
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("select[name='Agency']")).Selector
                    ().SelectByText(value);
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("select[name='SupportContractId]'")).Selector().
                    SelectByText(value);
            }
        }

        public string StreetName
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='Strasse']")).TypeText(value); }
        }

        public string Language
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("select[name='LanguageId]'")).Selector().
                    SelectByText(value);
            }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='www']")).TypeText(value); }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='abbrechen']")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("input[value='weiter']")); }
        }

        public string CustomerNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector("input[name='CustomerId']")).TypeText(value); }
        }

        public string CashIntegrator
        {
            set { throw new NotSupportedException("CashIntegrator will be set separately"); }
        }

        public string Segment
        {
            set { throw new NotImplementedException(); }
        }

        public string CustomerSegment
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#CustomerSegment")).Selector().
                    SelectByText(value);
            }
        }

        #endregion
    }
}
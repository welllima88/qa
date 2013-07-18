using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics.TestObjects.Customer
{
    public class CustomerCreate : WebObject, ICustomer
    {
        public string Segment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#CustomerSegment")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        #region ICustomerCreate Members

        public string StreetName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Strasse']")).TypeText(value); }
        }

        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='abbrechen']")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input[value='weiter']")); }
        }

        public string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='CountryId']"))
                         .Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string SbsBillingTenant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#BillingTenant")).
                          Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string Ep2MerchantId
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).GetCssValue("value"); }
        }

        public string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='PLZ']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Ort']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string AdressAddition
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Zusatz']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Postfach']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Region']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Telefon2']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Fax']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='Email']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Guid { get; set; }

        public string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerName']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='SapNumber']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("td[name='Name']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#StructureId")).
                          Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string SbsAdressNumber
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string SbsCurrency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#SBSCurrency")).Selector
                    ().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string CategoryCode
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='CategoryCode']")).Selector().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select[name='Agency']")).Selector
                    ().SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='SupportContractId]'")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string StreetNo { get; set; }

        public string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select[name='LanguageId]'")).Selector().
                          SelectByText(value);
            }
            get { throw new NotImplementedException(); }
        }

        public string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='www']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string CashIntegrator
        {
            set { throw new NotSupportedException("CashIntegrator will be set separately"); }
            get { throw new NotImplementedException(); }
        }

        public string CustomerNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input[name='CustomerId']")).TypeText(value); }
            get { throw new NotImplementedException(); }
        }

        public string SbsDebitNumber { get; private set; }

        #endregion
    }
}
using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerCreate : WebObject, ICustomer
    {
        public IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_cancelButton")); }
        }

        public IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_saveButton")); }
        }

        public string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).TypeText(value); }
        }

        public string SbsCurrency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SbsCurrency)).Selector
                    ().SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SbsCurrency)).Selector().SelectedOption.Text;
            }
        }

        public string Country
        {
            set { WebDriver.FindSuggesterElement(By.CssSelector(CustomerRes.Country)).Suggestor(value); }
            get { return WebDriver.FindElement(By.CssSelector(CustomerRes.Country)).Text; }
        }

        public string SbsBillingTenant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SbsBillingTenant)).
                          Selector().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SbsBillingTenant)).
                                 Selector().SelectedOption.Text;
            }
        }

        public string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).Text; }
        }

        public string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).Text; }
        }

        public string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition))
                         .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition))
                                .Text;
            }
        }

        public string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).Text; }
        }

        public string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).
                          TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).
                                 Text;
            }
        }

        public string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).
                          TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).
                                 Text;
            }
        }

        public string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).
                          TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).
                                 Text;
            }
        }

        public string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).Text; }
        }

        public string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).
                          TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).
                                 Text;
            }
        }

        public string Guid
        {
            get { throw new NotSupportedException("Not available in create mode"); }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).Text; }
        }

        public string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).Text; }
        }

        public string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).Text; }
        }

        public string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Supplier)).
                          Selector().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Supplier)).
                                 Selector().SelectedOption.Text;
            }
        }

        public string SbsAdressNumber
        {
            get { throw new NotSupportedException("Not available in create mode"); }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string CategoryCode
        {
            set
            {
                WebDriver.FindSuggesterElement(
                    By.CssSelector(CustomerRes.CategoryCode)).Suggestor(value);
            }
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(CustomerRes.CategoryCode)).Text;
            }
        }

        public string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Agency)).Selector
                    ().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Agency)).Selector
                    ().SelectedOption.Text;
            }
        }

        public string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(CustomerRes.SupportContract)).Selector().
                          SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(CustomerRes.SupportContract)).Selector().SelectedOption.Text;
            }
        }

        public string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).
                          TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).Text; }
        }

        public string Language
        {
            set
            {
                WebDriver.FindSuggesterElement(By.CssSelector(
                    CustomerRes.Language)).Suggestor(value);
            }
            get
            {
                return WebDriver.FindElement(By.CssSelector(
                    CustomerRes.Language)).Text;
            }
        }

        public string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).Text; }
        }

        public string CustomerNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerNumber)).TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerNumber)).Text; }
        }

        public string SbsDebitNumber
        {
            get { throw new NotSupportedException("Not available in create mode"); }
            set { throw new NotSupportedException("Not available in create mode"); }
        }

        public string CashIntegrator
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector(CustomerRes.CashIntegrator)).Selector()
                         .
                          SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector(CustomerRes.CashIntegrator)).Selector()
                                .SelectedOption.Text;
            }
        }

        public string Segment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Segment)).Selector().
                          SelectByText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Segment)).Text; }
        }
    }
}
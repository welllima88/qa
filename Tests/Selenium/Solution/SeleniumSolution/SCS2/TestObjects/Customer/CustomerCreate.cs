using System;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Customer
{
    public class CustomerCreate : WebObject, ICustomerCreate
    {
        public CustomerCreate(IWebDriverAdapter driver)
            : base(driver)
        {
        }

        #region ICustomerCreate Members

        public string Country
        {
            set { Driver.FindSuggesterElement(By.CssSelector(Customer.Country)).Suggestor(value); }
            get { return Driver.FindElement(By.CssSelector(Customer.Country)).Text; }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.SbsBillingTenant)).
                    Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.SbsBillingTenant)).
                    Selector().SelectedOption.Text;
            }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Zip)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.Zip)).Text; }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.City)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.City)).Text; }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.AdressAddition))
                    .TypeText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.AdressAddition))
                    .Text;
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Po)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.Po)).Text; }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Region)).
                    TypeText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Region)).
                    Text;
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Telephone)).
                    TypeText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Telephone)).
                    Text;
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Mobile)).
                    TypeText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Mobile)).
                    Text;
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Fax)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.Fax)).Text; }
        }

        public string Email
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Email)).
                    TypeText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Email)).
                    Text;
            }
        }

        public string CustomerName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerName)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerName)).Text; }
        }

        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.SapNumber)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.SapNumber)).Text; }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CompanyName)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.CompanyName)).Text; }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Supplier)).
                    Selector().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Supplier)).
                    Selector().SelectedOption.Text;
            }
        }


        public string SbsCurrency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.SbsCurrency)).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                Driver.FindSuggesterElement(
                    By.CssSelector(Customer.CategoryCode)).Suggestor(value);
            }
            get
            {
                return Driver.FindElement(
                    By.CssSelector(Customer.CategoryCode)).Text;
            }
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Agency)).Selector
                    ().SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Agency)).Selector
                    ().SelectedOption.Text;
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(Customer.SupportContract)).Selector().
                    SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(Customer.SupportContract)).Selector().SelectedOption.Text;
            }
        }

        public string StreetName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.StreetName)).
                    TypeText(value);
            }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.StreetName)).Text; }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    Customer.Language)).Suggestor(value);
            }
            get
            {
                return Driver.FindElement(By.CssSelector(
                    Customer.Language)).Text;
            }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Web)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.Web)).Text; }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_cancelButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_saveButton")); }
        }

        public string CustomerNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerNumber)).TypeText(value); }
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerNumber)).Text; }
        }

        public string CashIntegrator
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(Customer.CashIntegrator)).Selector()
                    .
                    SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(
                    By.CssSelector(Customer.CashIntegrator)).Selector()
                    .SelectedOption.Text;
            }
        }

        public string Segment
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Segment)).Selector().
                    SelectByText(value);
            }
            get
            {
                return Driver.FindAdaptedElement(By.CssSelector(Customer.Segment)).Selector().
                    SelectedOption.Text;
            }
        }

        public string Ep2MerchantId
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Customer.Ep2MerchantId)).Text; }
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Ep2MerchantId)).TypeText(value); }
        }

        #endregion
    }
}
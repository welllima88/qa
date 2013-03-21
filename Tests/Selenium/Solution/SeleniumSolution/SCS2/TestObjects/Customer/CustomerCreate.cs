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
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(Customer.Country))
                    .Suggestor(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.SbsBillingTenant)).
                    Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Zip)).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.City)).TypeText(value); }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.AdressAddition))
                    .TypeText(value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Po)).TypeText(value); }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Region)).
                    TypeText(value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Telephone)).
                    TypeText(value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Mobile)).
                    SendKeys(value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Fax)).TypeText(value); }
        }

        public string Email
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Email)).
                    TypeText(value);
            }
        }

        public string CustomerName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerName)).TypeText(value); }
        }

        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.SapNumber)).TypeText(value); }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CompanyName)).TypeText(value); }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Supplier)).
                    Selector().SelectByText(value);
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
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.Agency)).Selector
                    ().SelectByText(value);
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
        }

        public string StreetName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.StreetName)).
                    TypeText(value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    Customer.Language)).Suggestor(value);
            }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.Web)).TypeText(value); }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector("_cancelButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector("_saveButton")); }
        }

        public string CustomerNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerNumber)).TypeText(value); }
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
        }

        public string CustomerSegment
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Customer.CustomerSegment)).Selector().
                    SelectByText(value);
            }
        }

        #endregion
    }
}
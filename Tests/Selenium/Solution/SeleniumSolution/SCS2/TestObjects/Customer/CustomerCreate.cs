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
            Prefix = "#ctl00_bodyContentPlaceHolder";
        }

        #region ICustomerCreate Members

        public string Country
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(Prefix +"_addressControl_sugCountrytbx"))
                    .Suggestor(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix +"_customerSbsBillingTenant")).
                    Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_zipTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_zipTextBox")).SendKeys(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_cityTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_cityTextBox")).SendKeys
                    (
                        value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_addressAdditionTextBox"))
                    .
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_addressAdditionTextBox"))
                    .
                    SendKeys(
                        value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_poTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_poTextBox")).SendKeys(
                    value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_regionTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_regionTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephoneTextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephoneTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephone2TextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_telephone2TextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_faxTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_faxTextBox")).SendKeys(
                    value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_emailTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_emailTextBox")).
                    SendKeys(value);
            }
        }

        public string CustomerName
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_customerNameTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_customerNameTextBox")).SendKeys(value);
            }
        }

        public string SapNumber
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_sapNumberInput")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_sapNumberInput")).SendKeys(value);
            }
        }

        public string CompanyName
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_inpCompanyName")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_inpCompanyName")).SendKeys(value);
            }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix +"_supplierDropDown_dnSupplier")).
                    Selector().SelectByText(value);
            }
        }


        public string SbsCurrency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix +"_customerSbsCurrency")).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                Driver.FindSuggesterElement(
                    By.CssSelector(Prefix +"_rowCategoryCode_sugDropDowntbx")).Suggestor(value);
            }
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix +"_rowAgency_sugAgency")).Selector
                    ().SelectByText(value);
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(Prefix +"_rowSupportContract_ddSupportContract")).Selector().
                    SelectByText(value);
            }
        }

        public string StreetName
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_streetNameTextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_streetNameTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    Prefix +"_addressControl_sugLanguagetbx")).Suggestor(value);
            }
        }

        public string Web
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_webTextBox")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_addressControl_webTextBox")).SendKeys(
                    value);
            }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_cancelButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix +"_saveButton")); }
        }

        public string CustomerNumber
        {
            set
            {
                Driver.FindElement(By.CssSelector(Prefix +"_customerNumberInput")).Clear();
                Driver.FindElement(By.CssSelector(Prefix +"_customerNumberInput")).SendKeys(
                    value);
            }
        }

        public string CashIntegrator
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("select#ctl00_bodyContentPlaceHolder_rowCashIntegrator_sugCashIntegrator")).Selector()
                    .
                    SelectByText(value);
            }
        }

        public string CustomerSegment
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix +"_customerSegment")).Selector().
                    SelectByText(value);
            }
        }

        #endregion
    }
}
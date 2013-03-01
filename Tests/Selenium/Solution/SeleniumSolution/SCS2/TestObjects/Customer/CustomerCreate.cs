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
                Driver.FindSuggesterElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_sugCountrytbx"))
                    .Suggestor(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsBillingTenant")).
                    Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_zipTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_zipTextBox")).SendKeys(
                    value);
            }
        }

        public string City
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_cityTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_cityTextBox")).SendKeys
                    (
                        value);
            }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_addressAdditionTextBox"))
                    .
                    Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_addressAdditionTextBox"))
                    .
                    SendKeys(
                        value);
            }
        }

        public string Po
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_poTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_poTextBox")).SendKeys(
                    value);
            }
        }

        public string Region
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_regionTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_regionTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephoneTextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephoneTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephone2TextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_telephone2TextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Fax
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_faxTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_faxTextBox")).SendKeys(
                    value);
            }
        }

        public string Email
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_emailTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_emailTextBox")).
                    SendKeys(value);
            }
        }

        public string CustomerName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNameTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNameTextBox")).SendKeys(value);
            }
        }

        public string SapNumber
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_sapNumberInput")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_sapNumberInput")).SendKeys(value);
            }
        }

        public string CompanyName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCompanyName")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_inpCompanyName")).SendKeys(value);
            }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_supplierDropDown_dnSupplier")).
                    Selector().SelectByText(value);
            }
        }


        public string SbsCurrency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSbsCurrency")).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                Driver.FindSuggesterElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_rowCategoryCode_sugDropDowntbx")).Suggestor(value);
            }
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_rowAgency_sugAgency")).Selector
                    ().SelectByText(value);
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector("#ctl00_bodyContentPlaceHolder_rowSupportContract_ddSupportContract")).Selector().
                    SelectByText(value);
            }
        }

        public string StreetName
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_streetNameTextBox")).
                    Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_streetNameTextBox")).
                    SendKeys(
                        value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    "#ctl00_bodyContentPlaceHolder_addressControl_sugLanguagetbx")).Suggestor(value);
            }
        }

        public string Web
        {
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_webTextBox")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_addressControl_webTextBox")).SendKeys(
                    value);
            }
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
            set
            {
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNumberInput")).Clear();
                Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerNumberInput")).SendKeys(
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
                Driver.FindAdaptedElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_customerSegment")).Selector().
                    SelectByText(value);
            }
        }

        #endregion
    }
}
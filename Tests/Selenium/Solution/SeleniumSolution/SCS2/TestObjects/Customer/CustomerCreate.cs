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
                Driver.FindSuggesterElement(By.CssSelector(Prefix + "_addressControl_sugCountrytbx"))
                    .Suggestor(value);
            }
        }

        public string SbsBillingTenant
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_customerSbsBillingTenant")).
                    Selector().SelectByText(value);
            }
        }

        public string Zip
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_zipTextBox")).TypeText(value); }
        }

        public string City
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_cityTextBox")).TypeText(value); }
        }

        public string AdressAddition
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_addressAdditionTextBox"))
                    .TypeText(value);
            }
        }

        public string Po
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_poTextBox")).TypeText(value); }
        }

        public string Region
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_regionTextBox")).
                    TypeText(value);
            }
        }

        public string Telephone
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_telephoneTextBox")).
                    TypeText(value);
            }
        }

        public string Mobile
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_telephone2TextBox")).
                    SendKeys(value);
            }
        }

        public string Fax
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_faxTextBox")).TypeText(value); }
        }

        public string Email
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_emailTextBox")).
                    TypeText(value);
            }
        }

        public string CustomerName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_customerNameTextBox")).TypeText(value); }
        }

        public string SapNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_sapNumberInput")).TypeText(value); }
        }

        public string CompanyName
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_inpCompanyName")).TypeText(value); }
        }


        public string Supplier
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_supplierDropDown_dnSupplier")).
                    Selector().SelectByText(value);
            }
        }


        public string SbsCurrency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_customerSbsCurrency")).Selector
                    ().SelectByText(value);
            }
        }

        public string CategoryCode
        {
            set
            {
                Driver.FindSuggesterElement(
                    By.CssSelector(Prefix + "_rowCategoryCode_sugDropDowntbx")).Suggestor(value);
            }
        }

        public string Agency
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_rowAgency_sugAgency")).Selector
                    ().SelectByText(value);
            }
        }

        public string SupportContract
        {
            set
            {
                Driver.FindAdaptedElement(
                    By.CssSelector(Prefix + "_rowSupportContract_ddSupportContract")).Selector().
                    SelectByText(value);
            }
        }

        public string StreetName
        {
            set
            {
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_streetNameTextBox")).
                    TypeText(value);
            }
        }

        public string Language
        {
            set
            {
                Driver.FindSuggesterElement(By.CssSelector(
                    Prefix + "_addressControl_sugLanguagetbx")).Suggestor(value);
            }
        }

        public string Web
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_addressControl_webTextBox")).TypeText(value); }
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_cancelButton")); }
        }

        public IWebElement SaveButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "_saveButton")); }
        }

        public string CustomerNumber
        {
            set { Driver.FindAdaptedElement(By.CssSelector(Prefix + "_customerNumberInput")).TypeText(value); }
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
                Driver.FindAdaptedElement(By.CssSelector(Prefix + "_customerSegment")).Selector().
                    SelectByText(value);
            }
        }

        #endregion
    }
}
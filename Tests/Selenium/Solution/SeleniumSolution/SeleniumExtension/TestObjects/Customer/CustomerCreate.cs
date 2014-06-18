using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Customer
{
    public class CustomerCreate : WebObject
    {
        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("ipnut#cancel")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("input#save")); }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId")).Text; }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId"))
                    .TextBox()
                    .TypeText(value);
            }
        }

        public static string SbsCurrency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CurrencyCode")).Selector
                    ().SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CurrencyCode"))
                        .Selector()
                        .SelectedOption.Text;
            }
        }

        public static string Country
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_Address_CountryId"))
                        .TextBox()
                        .Text();
            }
        }

        public static string SbsBillingTenant
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_BillingTenantId")).
                    Selector().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_BillingTenantId")).
                    Selector().SelectedOption.Text;
            }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).Text; }
        }

        public static string City
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).Text; }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                    .TextBox().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                    .Text;
            }
        }

        public static string Po
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).Text; }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region"))
                    .TextBox()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region")).
                    Text;
            }
        }

        public static string Telephone
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone"))
                    .TextBox()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Telephone")).
                    Text;
            }
        }

        public static string Mobile
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile"))
                    .TextBox()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Mobile")).
                    Text;
            }
        }

        public static string Fax
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).Text; }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email"))
                    .TextBox()
                    .TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email")).
                    Text;
            }
        }

        public static string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).Text; }
        }

        public static string SapNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).Text; }
        }

        public static string CompanyName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).Text; }
        }

        public static string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#StructureId")).
                    Selector().SelectByText(value);
                SaveButton.Click();
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_StructureId")).
                    Selector().SelectedOption.Text;
            }
        }

        public static string CategoryCode
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#Preferences_CategoryCodeId"))
                    .Selector()
                    .SelectByText(value);
            }
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector("select#Preferences_CategoryCodeId")).Text;
            }
        }

        public static string Agency
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_AgencyId")).Selector
                    ().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_AgencyId")).Selector
                    ().SelectedOption.Text;
            }
        }

        public static string SupportContract
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select#Preferences_SupportContractId")).Selector().
                    SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector("select#Preferences_SupportContractId")).Selector().SelectedOption.Text;
            }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street"))
                    .TextBox()
                    .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street")).Text; }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(
                    "select#CustomerData_Address_LanguageId")).Selector().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(
                    "select#CustomerData_Address_LanguageId")).TextBox().Text();
            }
        }

        public static string Web
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web")).TextBox().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web")).Text; }
        }

        public static string CashIntegrator
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.CssSelector("select#Preferences_CashIntegratorId")).Selector()
                    .SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(
                    By.CssSelector("select#Preferences_CashIntegratorId")).Selector()
                    .SelectedOption.Text;
            }
        }

        public static string Segment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CustomerSegmentId")).Selector().
                    SelectByText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CustomerSegmentId")).Text; }
        }
    }
}
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Customer
{
    public class Create : WebObject
    {
        public static IWebElementAdapter CancelButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("ipnut#cancel")); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")); }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId")).Text; }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Ep2MerchantId"))
                    .TextField()
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
                        .SelectedOption;
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
                        .TextField()
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
                    Selector().SelectedOption;
            }
        }

        public static string Zip
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP"))
                    .TextField()
                    .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_ZIP")).Text; }
        }

        public static string City
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City"))
                    .TextField()
                    .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_City")).Text; }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Addition"))
                    .TextField().TypeText(value);
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
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).TextField().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_PO")).Text; }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Region"))
                    .TextField()
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
                    .TextField()
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
                    .TextField()
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
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax"))
                    .TextField()
                    .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Fax")).Text; }
        }

        public static string Email
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Email"))
                    .TextField()
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
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).TextField().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Name")).Text; }
        }

        public static string SapNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).TextField().TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_SapNumber")).Text; }
        }

        public static string CompanyName
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName"))
                    .TextField()
                    .TypeText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_CompanyName")).Text; }
        }

        public static string Supplier
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#StructureId")).
                    Selector().SelectByText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector("select#StructureId")).
                    Selector().SelectedOption;
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
                return WebDriver.FindAdaptedElement(
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
                    ().SelectedOption;
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
                    By.CssSelector("select#Preferences_SupportContractId")).Selector().SelectedOption;
            }
        }

        public static string StreetNo
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Street"))
                    .TextField()
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
                    "select#CustomerData_Address_LanguageId")).TextField().Text();
            }
        }

        public static string Web
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#CustomerData_Address_Web"))
                    .TextField()
                    .TypeText(value);
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
                    .SelectedOption;
            }
        }

        public static string SbsSegment
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CustomerSegmentId")).Selector().
                    SelectByText(value);
            }
            get { return WebDriver.FindAdaptedElement(By.CssSelector("select#CustomerData_CustomerSegmentId")).Text; }
        }

        public static IWebElementAdapter Confirm
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static string WesMandant
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.Id("Preferences_WESMandantId")).Selector()
                    .SelectByText(value);
            }
        }
    }
}
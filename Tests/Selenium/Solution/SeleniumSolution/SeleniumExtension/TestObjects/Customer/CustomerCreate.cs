using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Customer
{
    public class CustomerCreate : WebObject
    {
        public static IWebElement CancelButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_cancelButton")); }
        }

        public static IWebElement SaveButton
        {
            get { return WebDriver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_saveButton")); }
        }

        public static string Ep2MerchantId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).Text; }
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Ep2MerchantId)).TextBox().TypeText(value); }
        }

        public static string SbsCurrency
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

        public static string Country
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Country)).Suggestor().TypeAndChoose(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Country)).TextBox().Text(); }
        }

        public static string SbsBillingTenant
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

        public static string Zip
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Zip)).Text; }
        }

        public static string City
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.City)).Text; }
        }

        public static string AdressAddition
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition))
                         .TextBox().TypeText(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.AdressAddition))
                                .Text;
            }
        }

        public static string Po
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Po)).Text; }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).TextBox().TypeText(value); }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Region)).
                                 Text;
            }
        }

        public static string Telephone
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).TextBox().TypeText(value); }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Telephone)).
                                 Text;
            }
        }

        public static string Mobile
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).TextBox().TypeText(value); }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Mobile)).
                                 Text;
            }
        }

        public static string Fax
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Fax)).Text; }
        }

        public static string Email
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).TextBox().TypeText(value); }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Email)).
                                 Text;
            }
        }

        public static string CustomerName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerName)).Text; }
        }

        public static string SapNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.SapNumber)).Text; }
        }

        public static string CompanyName
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CompanyName)).Text; }
        }

        public static string Supplier
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

        public static string CategoryCode
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CategoryCode)).Suggestor().TypeAndChoose(value); }
            get
            {
                return WebDriver.FindElement(
                    By.CssSelector(CustomerRes.CategoryCode)).Text;
            }
        }

        public static string Agency
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

        public static string SupportContract
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

        public static string StreetNo
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.StreetName)).Text; }
        }

        public static string Language
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(
                    CustomerRes.Language)).Suggestor().TypeAndChoose(value);
            }
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(
                    CustomerRes.Language)).TextBox().Text();
            }
        }

        public static string Web
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.Web)).Text; }
        }

        public static string CustomerNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerNumber)).TextBox().TypeText(value); }
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CustomerRes.CustomerNumber)).Text; }
        }

        public static string CashIntegrator
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

        public static string Segment
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
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Administration.SimCard
{
    public class Edit : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")).Button(); }
        }

        public static string NetProvider
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_NetworkProviderId")).
                    Selector().SelectByText(value);
            }
        }

        public static string SimCardNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_CardNumber")).TextField().TypeText(value);
            }
        }

        public static string MobileNumber
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_MobileNumber")).TextField().TypeText(value);
            }
        }

        public static string Pin
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PIN")).TextField().TypeText(value); }
        }

        public static string Puk
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_PUK")).TextField().TypeText(value); }
        }

        public static bool Status
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_IsActive")).
                    CheckBox().Set(value);
            }
        }

        public static string TerminalId
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#TerminalId")).TextField().TypeText(value); }
        }

        public static string Region
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_LocationId")).
                    Selector().SelectByText(value);
            }
        }

        public static string Usage
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("select#SIMCard_UsageId")).
                    Selector().SelectByText(value);
            }
        }
    }
}
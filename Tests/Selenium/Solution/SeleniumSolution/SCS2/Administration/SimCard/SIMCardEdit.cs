using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Administration.SimCard
{
    public class SimCardEdit : WebObject
    {
        public static IWebElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("input#save")); }
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
            set { WebDriver.FindAdaptedElement(By.CssSelector("input#SIMCard_CardNumber")).TextField().TypeText(value); }
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
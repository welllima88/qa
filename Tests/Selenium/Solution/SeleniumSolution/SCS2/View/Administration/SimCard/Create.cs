using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Administration.SimCard
{
    public class Create : WebObject
    {
        public static ButtonElement SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#save")).Button(); }
        }

        public static string NetProvider
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_NetworkProviderId")).Selector().SelectByText(value);
            }
        }

        public static string SimCardNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_CardNumber")).TextField().TypeText(value); }
        }

        public static string MobileNumber
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_MobileNumber")).TextField().TypeText(value); }
        }

        public static string Pin
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PIN")).TextField().TypeText(value); }
        }

        public static string Puk
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_PUK")).TextField().TypeText(value); }
        }

        public static string Region
        {
            set { WebDriver.FindAdaptedElement(By.CssSelector("#SIMCard_LocationId")).Selector().SelectByText(value); }
        }
    }
}
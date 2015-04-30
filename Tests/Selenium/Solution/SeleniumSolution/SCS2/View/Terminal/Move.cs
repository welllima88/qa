using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal
{
    public class Move : WebObject
    {
        public static bool UpdateReceipt
        {
            set { WebDriver.FindAdaptedElement(By.Id("TakeAddressFromNewLocation")).CheckBox().Set(value); }
        }

        public static IWebElementAdapter SaveButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }

        public static void SelectLocation(string companyName)
        {
            WebDriver.FindAdaptedElement(By.Id("LocationId")).Selector().SelectByText(companyName);
        }
    }
}
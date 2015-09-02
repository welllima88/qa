using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Terminal
{
    public class SaferPay : WebObject
    {
        public static string Status
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.Id("TerminalStateSubState"))
                    .Selector()
                    .SelectByText(value);
            }
        }

        public static string Reason
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.Id("StateReason"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static string ECommerceIndicator
        {
            set
            {
                WebDriver.FindAdaptedElement(
                    By.Id("ECommerceText"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static void Save()
        {
            WebDriver.FindAdaptedElement(
                By.Id("save")).Click();
        }
    }
}
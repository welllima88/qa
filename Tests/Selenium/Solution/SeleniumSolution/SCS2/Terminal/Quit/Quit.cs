using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Quit
{
    public class Quit : WebObject
    {
        public static string State
        {
            set { WebDriver.FindAdaptedElement(By.Id("StateAndSubState")).Selector().SelectByText(value); }
        }

        public static string Delivery
        {
            set { WebDriver.FindAdaptedElement(By.Id("SelectedDeliveryType")).Selector().SelectByText(value); }
        }

        public static string Reason
        {
            set { WebDriver.FindAdaptedElement(By.Id("Motivation")).TextField().TypeText(value); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand
{
    public class ServiceCenter : WebObject
    {
        public static IWebElementAdapter ExternId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ExternId")); }
        }

        public static IWebElementAdapter NetAdress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SCNetAddress")); }
        }
    }
}
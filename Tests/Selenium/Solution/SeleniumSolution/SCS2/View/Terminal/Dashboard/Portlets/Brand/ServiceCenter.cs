using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets.Brand
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
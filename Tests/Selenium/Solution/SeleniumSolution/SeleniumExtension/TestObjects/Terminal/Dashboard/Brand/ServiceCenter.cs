using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Terminal.Dashboard.Brand
{
    public class ServiceCenter : WebObject
    {
        public IWebElementAdapter ExternId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#ExternId")); }
        }

        public IWebElementAdapter NetAdress
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("#SCNetAddress")); }
        }
    }
}
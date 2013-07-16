using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Brand
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
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard.Brand
{
    public class ServiceCenter : WebObject
    {
        public ServiceCenter(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElementAdapter ExternId
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#ExternId")); }
        }

        public IWebElementAdapter NetAdress
        {
            get { return Driver.FindAdaptedElement(By.CssSelector("#SCNetAddress")); }
        }
    }
}
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class SimCardMenu : MenuObject
    {
        public IWebElement SimCardManagement
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.SimCardManagement)); }
        }
    }
}
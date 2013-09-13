using OpenQA.Selenium;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common.Menu
{
    public class SimCardMenu : MenuObject
    {
        public IWebElement SimCardManagement
        {
            get { return WebDriver.FindElement(By.CssSelector(Menu.SimCardManagement)); }
        }
    }
}
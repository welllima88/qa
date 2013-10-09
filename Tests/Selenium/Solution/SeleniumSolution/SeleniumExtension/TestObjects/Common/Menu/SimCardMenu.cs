using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class SimCardMenu : MenuObject
    {
        public IWebElement SimCardManagement
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }
    }
}
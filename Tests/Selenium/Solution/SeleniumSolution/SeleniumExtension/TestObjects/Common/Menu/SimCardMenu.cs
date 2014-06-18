using OpenQA.Selenium;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class SimCardMenu : MenuObject
    {
        public static IWebElement SimCardManagement
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }
    }
}
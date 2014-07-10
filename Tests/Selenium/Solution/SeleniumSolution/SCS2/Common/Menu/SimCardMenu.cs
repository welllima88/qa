using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class SimCardMenu : WebObject
    {
        public static IWebElement SimCardManagement
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }
    }
}
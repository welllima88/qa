using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Menu
{
    public class SimCardMenu : WebObject
    {
        public static IWebElementAdapter SimCardManagement
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(MenuRes.SimCardManagement)); }
        }
    }
}
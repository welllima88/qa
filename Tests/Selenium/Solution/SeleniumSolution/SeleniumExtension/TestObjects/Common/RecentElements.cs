using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class RecentElements : WebObject
    {
        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return WebDriver.FindElements(By.CssSelector(CommonRes.RecentElements_Elements)); }
        }

        public IWebElement MostRecent
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.RecentElements_MostRecent)); }
        }
    }
}
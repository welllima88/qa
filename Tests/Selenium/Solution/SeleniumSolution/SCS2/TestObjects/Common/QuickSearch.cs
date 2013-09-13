using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public IWebElement SearchField
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.QuickSearch_SearchField)); }
        }

        public IWebElement SearchButton
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.QuickSearch_SearchButton)); }
        }
    }
}
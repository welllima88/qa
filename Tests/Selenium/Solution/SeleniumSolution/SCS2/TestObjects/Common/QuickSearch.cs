using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
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
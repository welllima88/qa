using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public QuickSearch(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement SearchField
        {
            get { return Driver.FindElement(By.CssSelector(Common.QuickSearch_SearchField)); }
        }

        public IWebElement SearchButton
        {
            get { return Driver.FindElement(By.CssSelector(Common.QuickSearch_SearchButton)); }
        }
    }
}
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    public abstract class AbstractSearchResult : WebObject 
    {
        protected AbstractSearchResult(IWebDriverAdapter driver)
            : base(driver)
        {
            // Prefix=""
        }
        public IWebElement LoadMore
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "p#searchSubmit")); }
        }
        public IWebElement FilterTextField
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "p#searchSubmit")); }
        }
    }
}
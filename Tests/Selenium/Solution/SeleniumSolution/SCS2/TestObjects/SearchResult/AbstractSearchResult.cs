using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.SearchResult
{
    public abstract class AbstractSearchResult : WebObject
    {
        /// <summary>
        /// It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        /// <param name="driver"></param>
        protected AbstractSearchResult(IWebDriverAdapter driver)
            : base(driver)
        {            
        }

        public IWebElement Headline
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "h2")); }
        }

        public IWebElement LoadMoreLink
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "span input[id^='loadMore']")); }
        }

        public IWebElement FilterTextField
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "span input[id$='Filter']")); }
        }
    }
}
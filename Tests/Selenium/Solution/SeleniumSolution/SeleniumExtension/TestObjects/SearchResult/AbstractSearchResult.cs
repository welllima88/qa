using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public abstract class AbstractSearchResult : WebObject
    {
        /// <summary>
        ///     It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        public IWebElement Headline
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + "h2")); }
        }

        public IWebElement LoadMoreLink
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + "span input[id^='loadMore']")); }
        }

        public IWebElement FilterTextField
        {
            get { return WebDriver.FindElement(By.CssSelector(Prefix + "span input[id$='Filter']")); }
        }
    }
}
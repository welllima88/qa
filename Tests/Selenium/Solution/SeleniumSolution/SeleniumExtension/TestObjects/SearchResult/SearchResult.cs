using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.SearchResult
{
    public class SearchResult : WebObject
    {
        /// <summary>
        ///     It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        public static string Headline
        {
            get { return WebDriver.FindElement(By.CssSelector("td#content h1")).Text; }
        }

        public IWebElement LoadMoreLink
        {
            get { return WebDriver.FindElement(By.CssSelector("span input[id^='loadMore']")); }
        }

        public IWebElement FilterTextField
        {
            get { return WebDriver.FindElement(By.CssSelector("span input[id$='Filter']")); }
        }
    }
}
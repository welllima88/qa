using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Search.Result
{
    public class SearchResult : WebObject
    {
        /// <summary>
        ///     It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        public static string Headline
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content h1")).Text; }
        }

        public static TextFieldElement FilterTextField(SearchDivLocator searchDivLocator)
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("span input[id$='Filter']")).TextField();
        }

        public static IWebElementAdapter LoadMoreLink(SearchDivLocator searchDivLocator)
        {
            return WebDriver.FindAdaptedElement(By.CssSelector(" span input[id^='loadMore']"));
        }

        public static IWebElementAdapter First(SearchDivLocator searchDivLocator)
        {
            return Result(searchDivLocator).FirstOrDefault(d => d.Displayed);
        }

        private static IEnumerable<IWebElementAdapter> Result(SearchDivLocator searchDivLocator)
        {
            WaitForSearchHasFinished();

            string cssb = "div#" + searchDivLocator.Section + " tbody#" + searchDivLocator.ResultId + " tr td a[href*='" +
                          searchDivLocator.LinkPart + "']";
            return WebDriver.FindAdaptedElements(By.CssSelector(cssb));
        }

        private static void WaitForSearchHasFinished()
        {
            WebDriverWait w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElements(By.CssSelector("div.progress-bar")).Count == 0);
        }
    }
}
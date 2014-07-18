using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.SearchResult
{
    public class SearchResults : WebObject
    {
        /// <summary>
        ///     It is recommended to set the prefix property to the appropiate container element
        /// </summary>
        public static string Headline
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content h1")).Text; }
        }

        public static IWebElementAdapter LoadMoreLink
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("span input[id^='loadMore']")); }
        }

        public static TextFieldElement FilterTextField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("span input[id$='Filter']")).TextField(); }
        }

        public static IWebElementAdapter First(SearchDivLocator searchDivLocator)
        {
            IWebElementAdapter element =
                WebDriver.FindAdaptedElement(
                    By.CssSelector("tbody#" + searchDivLocator.ResultId +
                                   " tr td a[href*='" + searchDivLocator.LinkPart + "']"));
            return element;
        }

        public static ReadOnlyCollection<IWebElementAdapter> Result(SearchDivLocator searchDivLocator)
        {
            return
                WebDriver.FindAdaptedElements(
                    By.CssSelector("tbody#" + searchDivLocator.ResultId + " tr td a[href*='" + searchDivLocator.LinkPart +
                                   "']"));
        }
    }
}
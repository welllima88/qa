using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Search
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
            return Result(searchDivLocator)[1];
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
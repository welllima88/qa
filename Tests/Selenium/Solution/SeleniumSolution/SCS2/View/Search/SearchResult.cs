using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Search
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

        public TextFieldElement FilterTextField()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("span input[id$='Filter']")).TextField();
        }

        public IWebElementAdapter LoadMoreLink()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector(" span input[id^='loadMore']"));
        }

        public static IWebElementAdapter First(string section)
        {
            WaitForSearchHasFinished();
            var cssb =
                string.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr>td>a strong",
                    //String.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr>td:nth-child(3)>a",
                    section);
            return WebDriver.FindAdaptedElement(By.CssSelector(cssb));
        }

        public static IEnumerable<IWebElementAdapter> Result(string section)
        {
            WaitForSearchHasFinished();
            var cssb = string.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr", section);
            return WebDriver.FindAdaptedElements(By.CssSelector(cssb)).Where(r => r.Displayed);
        }

        private static void WaitForSearchHasFinished()
        {
            var w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElement(By.CssSelector("div.progress-bar"))
                .GetAttribute("aria-valuenow")
                .Equals("100"));
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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

        public static TextFieldElement FilterTextField()
        {
            return WebDriver.FindAdaptedElement(By.CssSelector("span input[id$='Filter']")).TextField();
        }

        public static IWebElementAdapter LoadMoreLink(string customerctrl)
        {
            return WebDriver.FindAdaptedElement(By.CssSelector(" span input[id^='loadMore']"));
        }

        public static IWebElementAdapter First(string section)
        {
            return Result(section).FirstOrDefault(d => d.Displayed);
        }

        private static IEnumerable<IWebElementAdapter> Result(string section)
        {
            WaitForSearchHasFinished();

            string cssb = String.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr>td>a[ng-href]", section);
            return WebDriver.FindAdaptedElements(By.CssSelector(cssb));
        }

        private static void WaitForSearchHasFinished()
        {
            WebDriverWait w = WebDriver.WebDriverWait();
            w.Until(d => d.FindElement(By.CssSelector("div.progress-bar"))
                .GetAttribute("aria-valuenow")
                .Equals("100"));
        }
    }
}
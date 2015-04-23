using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.View.Search
{
    public class SearchResult : WebObject
    {
        private readonly string _section;

        public SearchResult(string section)
        {
            _section = section;
        }

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

        public IWebElementAdapter First()
        {
            WaitForSearchHasFinished();
            string cssb =
                String.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr>td>a strong",
                    //String.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr>td:nth-child(3)>a",
                    _section);
            return WebDriver.FindAdaptedElement(By.CssSelector(cssb));
        }

        public IEnumerable<IWebElementAdapter> Result()
        {
            WaitForSearchHasFinished();
            string cssb = String.Format("div[ng-app='searchApp']>div[ng-controller='{0}']>div>table>tbody>tr", _section);
            return WebDriver.FindAdaptedElements(By.CssSelector(cssb)).Where(r => r.Displayed);
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
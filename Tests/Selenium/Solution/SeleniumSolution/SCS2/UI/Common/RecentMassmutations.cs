using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class RecentMassmutations : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#BatchHistoryList div.panel-heading")).Text; }
        }

        public static IEnumerable<IWebElement> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("div#BatchHistoryList ul#BatchHistoryList>li")); }
        }

        public static IWebElement MostRecent
        {
            get { return Elements.ElementAt(0); }
        }
    }
}
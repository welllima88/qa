using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Administration.SimCard
{
    public class History : WebObject
    {
        private static IEnumerable<IWebElement> HistoryElements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#History tbody tr")); }
        }

        public static IEnumerable<string> HistoryList
        {
            get { return HistoryElements.Select(e => e.Text); }
        }
    }
}
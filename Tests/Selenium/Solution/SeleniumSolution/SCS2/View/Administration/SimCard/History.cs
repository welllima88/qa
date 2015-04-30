using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.SimCard
{
    public class History : WebObject
    {
        private static ReadOnlyCollection<IWebElementAdapter> HistoryElements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#History tbody tr")); }
        }

        public static IEnumerable<string> HistoryList
        {
            get { return WebDriver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
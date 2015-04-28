using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Administration.SimCard
{
    public class History : WebObject
    {
        private static ReadOnlyCollection<IWebElementAdapter> HistoryElements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#History tbody tr")); }
        }

        public static List<string> HistoryList
        {
            get { return WebDriver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    public class SimCardHistory : WebObject
    {
        private static ReadOnlyCollection<IWebElement> HistoryElements
        {
            get { return WebDriver.FindElements(By.CssSelector("table.dataTable tbody tr")); }
        }

        public static List<string> HistoryList
        {
            get { return WebDriver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
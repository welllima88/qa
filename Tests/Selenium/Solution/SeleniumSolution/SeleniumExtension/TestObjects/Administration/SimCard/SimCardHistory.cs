using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Administration.SimCard
{
    internal class SimCardHistory : WebObject
    {
        private ReadOnlyCollection<IWebElement> HistoryElements
        {
            get { return WebDriver.FindElements(By.CssSelector("table.dataTable tbody tr")); }
        }

        public List<string> HistoryList
        {
            get { return WebDriver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardHistory
    {
        private readonly IWebDriverAdapter _driver;

        public SimCardHistory(IWebDriverAdapter driver)
        {
            _driver = driver;
        }

        public ReadOnlyCollection<IWebElement> HistoryElements
        {
            get { return _driver.FindElements(By.CssSelector("table.dataTable tbody tr")); }
        }

        public List<String> HistoryList
        {
            get { return _driver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
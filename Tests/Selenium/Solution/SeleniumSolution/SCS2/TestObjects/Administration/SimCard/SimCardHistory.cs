using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Administration.SimCard
{
    internal class SimCardHistory : WebObject
    {
        public SimCardHistory(IWebDriverAdapter driver) : base(driver)
        {
        }

        public ReadOnlyCollection<IWebElement> HistoryElements
        {
            get { return Driver.FindElements(By.CssSelector("table.dataTable tbody tr")); }
        }

        public List<String> HistoryList
        {
            get { return Driver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
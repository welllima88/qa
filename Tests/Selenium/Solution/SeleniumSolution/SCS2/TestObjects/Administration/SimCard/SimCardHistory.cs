using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Administration.SimCard
{
    internal class SimCardHistory : WebObject
    {
        public ReadOnlyCollection<IWebElement> HistoryElements
        {
            get { return WebDriver.FindElements(By.CssSelector("table.dataTable tbody tr")); }
        }

        public List<String> HistoryList
        {
            get { return WebDriver.WebElementsAsStringList(HistoryElements); }
        }
    }
}
using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common
{
    public class RecentMassmutations : WebObject
    {
        public static String Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#BatchHistoryList div.panel-heading")).Text; }
        }

        public static ReadOnlyCollection<IWebElementAdapter> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("div#BatchHistoryList ul#BatchHistoryList>li")); }
        }

        public static IWebElementAdapter MostRecent
        {
            get { return Elements[0]; }
        }
    }
}
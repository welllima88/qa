using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common
{
    public class RecentMassmutations : WebObject
    {
        public static String Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.RecentMassmutations_Header)).Text; }
        }

        public static ReadOnlyCollection<IWebElementAdapter> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector(CommonRes.RecentMassmutations_Elements)); }
        }

        public static IWebElementAdapter MostRecent
        {
            get { return Elements[0]; }
        }
    }
}
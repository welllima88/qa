using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class RecentMassmutations : WebObject
    {
        public static String Header
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.RecentMassmutations_Header)).Text; }
        }

        public static ReadOnlyCollection<IWebElement> Elements
        {
            get { return WebDriver.FindElements(By.CssSelector(CommonRes.RecentMassmutations_Elements)); }
        }

        public static IWebElement MostRecent
        {
            get { return Elements[0]; }
        }
    }
}
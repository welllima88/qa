using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
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
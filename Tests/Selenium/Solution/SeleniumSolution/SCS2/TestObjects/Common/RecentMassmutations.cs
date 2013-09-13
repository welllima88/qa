using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common
{
    public class RecentMassmutations : WebObject
    {
        public String Header
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.RecentMassmutations_Header)).Text; }
        }

        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return WebDriver.FindElements(By.CssSelector(Common.RecentMassmutations_Elements)); }
        }

        public IWebElement MostRecent
        {
            get { return Elements[0]; }
        }
    }
}
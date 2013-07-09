using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class RecentMassmutations : WebObject
    {
        public RecentMassmutations(IWebDriverAdapter driver) : base(driver)
        {
        }

        public String Header
        {
            get { return Driver.FindElement(By.CssSelector(Common.RecentMassmutations_Header)).Text; }
        }

        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return Driver.FindElements(By.CssSelector(Common.RecentMassmutations_Elements)); }
        }

        public IWebElement MostRecent
        {
            get { return Elements[0]; }
        }
    }
}
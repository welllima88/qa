using System;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class RecentMassmutations : WebObject
    {
        public RecentMassmutations(IWebDriverAdapter driver) : base(driver)
        {
        }

        public String Header
        {
            get { return Driver.FindElement(By.CssSelector("#ctl00_bodyContentPlaceHolder_lblBatchTitle")).Text; }
        }

        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return Driver.FindElements(By.CssSelector("div.container a[id$='_hplBatchHistory']")); }
        }

        public IWebElement MostRecent
        {
            get { return RecentElement(1); }
        }

        public IWebElement RecentElement(int elementNo)
        {
            return Driver.FindElement(
                By.CssSelector("div.container a#ctl00_bodyContentPlaceHolder_rptBatchHistory_ctl" +
                               (elementNo - 1).ToString("00") +
                               "_hplBatchHistory"));
        }
    }
}
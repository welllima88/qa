using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class RecentElements : WebObject
    {
        public RecentElements(IWebDriverAdapter driver) : base(driver)
        {
        }

        public ReadOnlyCollection<IWebElement> Elements
        {
            get { return Driver.FindElements(By.CssSelector(Common.RecentElements_Elements)); }
        }


        public IWebElement MostRecent
        {
            get { return RecentElement(1); }
        }

        public List<String> RecentElementsAsList()
        {
            return Driver.WebElementsAsStringList(Elements);
        }

        public IWebElement RecentElement(int elementNo)
        {
            IWebElement e =
                Driver.FindElement(
                    By.CssSelector(Common.RecentElements_RecentElement_Prefix +
                                   (elementNo - 1).ToString("00") +
                                   Common.RecentElements_RecentElement_Suffix));
            return e;
        }
    }
}
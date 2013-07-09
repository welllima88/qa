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
            get { return Elements[0]; }
        }        
    }
}
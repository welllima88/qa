using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Common.Infotext
{
    public class ListView : WebObject
    {
        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")).Button(); }
        }

        private static IEnumerable<IWebElementAdapter> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#infotextList tbody tr td")); }
        }

        public static IEnumerable<string> List
        {
            get { return Elements.Select(e => e.Text); }
        }
    }
}
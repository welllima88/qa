using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        private static ReadOnlyCollection<IWebElementAdapter> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#infotextList tbody tr td.infotext")); }
        }

        public static IEnumerable<string> List
        {
            get { return WebDriver.WebElementsAsStringList(Elements); }
        }
    }
}
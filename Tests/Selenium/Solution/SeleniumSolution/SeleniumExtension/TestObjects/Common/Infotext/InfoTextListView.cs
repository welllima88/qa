using System.Collections.Generic;
using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Infotext
{
    public class InfoTextListView : WebObject
    {
        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div button#createInfotext")); }
        }

        private static IEnumerable<IWebElement> Elements
        {
            get { return WebDriver.FindElements(By.CssSelector("table#infotextList tbody tr td.infotext")); }
        }

        public static List<string> List
        {
            get { return WebDriver.WebElementsAsStringList(Elements); }
        }
    }
}
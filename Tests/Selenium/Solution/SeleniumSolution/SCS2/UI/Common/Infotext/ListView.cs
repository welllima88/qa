using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common.Infotext
{
    public class ListView : WebObject
    {
        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.Id("create")).Button(); }
        }

        private static IEnumerable<IWebElement> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#infotextList tbody tr")); }
        }

        public static IEnumerable<string> List
        {
            get { return Elements.Select(e => e.Text); }
        }
    }
}
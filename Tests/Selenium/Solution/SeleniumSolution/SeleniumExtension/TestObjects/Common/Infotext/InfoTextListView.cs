using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext
{
    public class InfoTextListView : WebObject
    {
        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div button#createInfotext")); }
        }

        private static ReadOnlyCollection<IWebElement> Elements
        {
            get { return WebDriver.FindElements(By.CssSelector("table#infotextList tbody tr td#infotext")); }
        }

        public static List<string> List
        {
            get { return WebDriver.WebElementsAsStringList(Elements); }
        }
    }
}
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Common.Infotext
{
    public class InfoTextListView : WebObject
    {
        public static ButtonElement CreateButton
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.Id("create")).Button();
            }
        }

        private static ReadOnlyCollection<IWebElementAdapter> Elements
        {
            get { return WebDriver.FindAdaptedElements(By.CssSelector("table#infotextList tbody tr td.infotext")); }
        }

        public static List<string> List
        {
            get { return WebDriver.WebElementsAsStringList(Elements); }
        }
    }
}
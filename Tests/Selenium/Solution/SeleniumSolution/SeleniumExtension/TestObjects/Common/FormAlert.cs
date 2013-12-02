using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class FormAlert : WebObject
    {
        public static List<string> FormAlertList
        {
            get { return WebDriver.WebElementsAsStringList(FormAlertElements); }
        }

        public static ReadOnlyCollection<IWebElement> FormAlertElements
        {
            get { return WebDriver.FindElements(By.CssSelector(CommonRes.FormAlert_FormAlertElements)); }
        }
    }
}
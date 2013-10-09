using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class FormAlert : WebObject
    {
        public List<string> FormAlertList
        {
            get { return WebDriver.WebElementsAsStringList(FormAlertElements); }
        }

        public ReadOnlyCollection<IWebElement> FormAlertElements
        {
            get { return WebDriver.FindElements(By.CssSelector(Common.FormAlert_FormAlertElements)); }
        }
    }
}
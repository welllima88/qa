using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class FormAlert : WebObject
    {
        public List<String> FormAlertList
        {
            get { return WebDriver.WebElementsAsStringList(FormAlertElements); }
        }

        public ReadOnlyCollection<IWebElement> FormAlertElements
        {
            get { return WebDriver.FindElements(By.CssSelector(Common.FormAlert_FormAlertElements)); }
        }
    }
}
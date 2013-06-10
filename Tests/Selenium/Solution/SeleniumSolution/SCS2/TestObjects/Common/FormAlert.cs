using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class FormAlert : WebObject
    {
        public FormAlert(IWebDriverAdapter driver) : base(driver)
        {
        }

        public List<String> FormAlertList
        {
            get { return Driver.WebElementsAsStringList(FormAlertElements); }
        }

        public ReadOnlyCollection<IWebElement> FormAlertElements
        {
            get { return Driver.FindElements(By.CssSelector(Common.FormAlert_FormAlertElements)); }
        }
    }
}
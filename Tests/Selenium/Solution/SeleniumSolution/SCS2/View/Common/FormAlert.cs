using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common
{
    public class FormAlert : WebObject
    {
        public static IEnumerable<string> FormAlertList
        {
            get
            {
                return WebDriver.FindAdaptedElements(By.CssSelector("div.formAlert div.body ul li")).Select(e => e.Text);
            }
        }

        public static IEnumerable<string> InvalidElementNames
        {
            get
            {
                return
                    WebDriver.FindElements(By.CssSelector("input.input-validation-error"))
                        .Select(e => e.GetAttribute("name"));
            }
        }
    }
}
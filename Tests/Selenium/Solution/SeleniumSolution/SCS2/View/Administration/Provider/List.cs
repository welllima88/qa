using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Administration.Provider
{
    public class List : WebObject
    {
        public static string Name
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Name")).Text; }
        }

        public static bool Status
        {
            get { return WebDriver.FindAdaptedElement(By.Id("Status")).Selected; }
        }

        public static string Filter
        {
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("input[ng-model='providerFilter']"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static IEnumerable<string> Providers
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(By.CssSelector("td#content div table tbody tr"))
                        .Select(e => e.Text);
            }
        }
    }
}
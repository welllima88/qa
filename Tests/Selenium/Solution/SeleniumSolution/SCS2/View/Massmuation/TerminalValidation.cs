using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Massmuation
{
    public class TerminalValidation : WebObject
    {
        public static List<string> Passwords
        {
            get
            {
                return
                    WebDriver.FindAdaptedElements(By.CssSelector("input[id$='inpPassword']"))
                        .Select(e => e.TextField().Text())
                        .ToList();
            }
        }

        public static List<string> ReferenceTerminalIds
        {
            get
            {
                return WebDriver.FindAdaptedElements(By.CssSelector("input[id$='inpReferenceTerminalId']"))
                    .Select(e => e.TextField().Text())
                    .ToList();
            }
        }

        public static int Count
        {
            get { return WebDriver.FindElements(By.CssSelector("tr[id$='_rowData']")).Count; }
        }

        public static List<string> Locations
        {
            get
            {
                return WebDriver.FindAdaptedElements(By.CssSelector("input[id$='_inpLocationId']"))
                    .Select(e => e.TextField().Text())
                    .ToList();
            }
        }

        public static IWebElement ExecuteButton
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.Id("save"));
            }
        }
    }
}
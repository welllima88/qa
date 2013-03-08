using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    public class TerminalInfo : WebObject
    {
        public TerminalInfo(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div.portletSummaryColumn";
        }
        //TODO: better locators 
        public string TerminalId
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")).Text; }
        }

        public string ExternTerminalId
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")).Text; }
        }

        public string Article
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")).Text; }
        }

        public string Status
        {
            get { return Driver.FindElement(By.CssSelector("input[value='Bearbeiten']")).Text; }
        }
    }
}
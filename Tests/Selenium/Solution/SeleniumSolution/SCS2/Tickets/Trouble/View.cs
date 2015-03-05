using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Tickets.Trouble
{
    public class View : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div.panel-heading")).Text; }
        }
    }
}
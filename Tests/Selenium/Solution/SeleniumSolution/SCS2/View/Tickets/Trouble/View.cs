using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Tickets.Trouble
{
    public class View : WebObject
    {
        public static string Header
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div.panel-heading")).Text; }
        }
    }
}
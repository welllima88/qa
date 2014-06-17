using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Mpd
{
    public class MpdListView : WebObject
    {
        public static IWebElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#create")); }
        }
    }
}
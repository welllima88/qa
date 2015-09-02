using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.UI.Mpd
{
    public class ListView : WebObject
    {
        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#create")).Button(); }
        }
    }
}
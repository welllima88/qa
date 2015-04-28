using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Mpd
{
    public class ListView : WebObject
    {
        public static ButtonElement CreateButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("button#create")).Button(); }
        }
    }
}
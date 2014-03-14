using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common.Infotext
{
    public class InfoTextListView : WebObject
    {
        public static IWebElement CreateInfotextButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("td#content div button[name='create'][href*='/InfoText/']")); }
        }
    }
}
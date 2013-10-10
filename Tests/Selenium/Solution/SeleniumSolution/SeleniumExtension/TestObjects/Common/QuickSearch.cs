using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public static IWebElementAdapter SearchField
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.QuickSearch_SearchField)); }
        }

        public static IWebElement SearchButton
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.QuickSearch_SearchButton)); }
        }
    }
}
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public static string SearchField
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.QuickSearch_SearchField))
                             .GetAttribute("value");
            }
            set { WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.QuickSearch_SearchField)).TextBox().TypeText(value); }
        }

        public static IWebElement SearchButton
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.QuickSearch_SearchButton)); }
        }

        public static void HitEnter()
        {
            WebDriver.FindElement(By.CssSelector(CommonRes.QuickSearch_SearchField)).SendKeys(Keys.Return);
        }
    }
}
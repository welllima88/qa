using OpenQA.Selenium;
using Six.Scs.Tests.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public static string SearchField
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.QuickSearch_SearchField))
                        .TextBox().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector(CommonRes.QuickSearch_SearchField)).TextBox().TypeText(value);
            }
        }

        public static IWebElement SearchButton
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.QuickSearch_SearchButton)); }
        }

        public static void HitEnter()
        {
            WebDriver.FindElement(By.CssSelector(CommonRes.QuickSearch_SearchField)).SendKeys(Keys.Return);
        }

        public static void Find(string searchString)
        {
            SearchField = searchString;
            HitEnter();
        }
    }
}
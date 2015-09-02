using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.UI.Common
{
    public class QuickSearch : WebObject
    {
        public static string SearchField
        {
            get
            {
                return
                    WebDriver.FindAdaptedElement(By.CssSelector("div#searchBar>input#searchText"))
                        .TextField().Text();
            }
            set
            {
                WebDriver.FindAdaptedElement(By.CssSelector("div#searchBar>input#searchText"))
                    .TextField()
                    .TypeText(value);
            }
        }

        public static IWebElement SearchButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#searchBar>p#searchSubmit")); }
        }

        public static void HitEnter()
        {
            WebDriver.FindElement(By.CssSelector("div#searchBar>input#searchText")).SendKeys(Keys.Return);
        }
    }
}
using OpenQA.Selenium;
using Six.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Application.View.Common
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

        public static IWebElementAdapter SearchButton
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#searchBar>p#searchSubmit")); }
        }

        public static void HitEnter()
        {
            WebDriver.FindElement(By.CssSelector("div#searchBar>input#searchText")).SendKeys(Keys.Return);
        }
    }
}
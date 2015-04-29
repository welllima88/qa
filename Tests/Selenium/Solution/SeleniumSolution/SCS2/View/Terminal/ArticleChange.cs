using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;

namespace Six.Scs.Test.View.Terminal
{
    public class ArticleChange : WebObject
    {
        public static IWebElementAdapter Change
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ChangeArticle")); }
        }

        public static IWebElementAdapter Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}
using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal
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
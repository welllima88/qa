using OpenQA.Selenium;
using Six.Test.Selenium.WebDriver.WebElements;
using IWebElement = Six.Test.Selenium.WebDriver.WebElements.IWebElement;

namespace Six.Scs.Test.View.Terminal
{
    public class ArticleChange : WebObject
    {
        public static IWebElement Change
        {
            get { return WebDriver.FindAdaptedElement(By.Id("ChangeArticle")); }
        }

        public static IWebElement Save
        {
            get { return WebDriver.FindAdaptedElement(By.Id("save")); }
        }
    }
}
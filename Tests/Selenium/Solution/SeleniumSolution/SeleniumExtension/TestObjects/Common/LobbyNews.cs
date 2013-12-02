using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension.Selenium.WebElements;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects.Common
{
    public class LobbyNews : WebObject
    {
        public static ReadOnlyCollection<IWebElement> NewsElements
        {
            get { return WebDriver.FindElements(By.CssSelector(CommonRes.LobbyNews_NewsElements)); }
        }

        public static IWebElement NewsTitle
        {
            get { return WebDriver.FindElement(By.CssSelector(CommonRes.LobbyNews_NewsTitle)); }
        }
    }
}
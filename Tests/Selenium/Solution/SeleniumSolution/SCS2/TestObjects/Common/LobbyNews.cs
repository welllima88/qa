using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Common
{
    public class LobbyNews : WebObject
    {
        public ReadOnlyCollection<IWebElement> NewsElements
        {
            get { return WebDriver.FindElements(By.CssSelector(Common.LobbyNews_NewsElements)); }
        }

        public IWebElement NewsTitle
        {
            get { return WebDriver.FindElement(By.CssSelector(Common.LobbyNews_NewsTitle)); }
        }
    }
}
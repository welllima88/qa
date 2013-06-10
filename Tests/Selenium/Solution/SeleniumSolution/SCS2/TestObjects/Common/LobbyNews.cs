using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class LobbyNews : WebObject
    {
        public LobbyNews(IWebDriverAdapter driver) : base(driver)
        {
        }

        public ReadOnlyCollection<IWebElement> NewsElements
        {
            get { return Driver.FindElements(By.CssSelector(Common.LobbyNews_NewsElements)); }
        }

        public IWebElement NewsTitle
        {
            get { return Driver.FindElement(By.CssSelector(Common.LobbyNews_NewsTitle)); }
        }
    }
}
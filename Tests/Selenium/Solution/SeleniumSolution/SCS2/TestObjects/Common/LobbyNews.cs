using System.Collections.ObjectModel;
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class LobbyNews : WebObject
    {
        public LobbyNews(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div.container ";
        }

        public ReadOnlyCollection<IWebElement> NewsElements
        {
            get { return Driver.FindElements(By.CssSelector(Prefix + "ul")); }
        }

        public IWebElement NewsTitle
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "span#ctl00_bodyContentPlaceHolder_lblNewsTitle h2")); }
        }
    }
}
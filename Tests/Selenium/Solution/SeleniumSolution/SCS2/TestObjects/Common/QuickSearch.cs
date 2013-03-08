using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common
{
    public class QuickSearch : WebObject
    {
        public QuickSearch(IWebDriverAdapter driver) : base(driver)
        {
            Prefix = "div#searchBar>";
        }

        public IWebElement SearchField
        {
            get { return Driver.FindElement(By.CssSelector(Prefix = "input#searchText")); }
        }

        public IWebElement SearchButton
        {
            get { return Driver.FindElement(By.CssSelector(Prefix + "p#searchSubmit")); }
        }
    }
}
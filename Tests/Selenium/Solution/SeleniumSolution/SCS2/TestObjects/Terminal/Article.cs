using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class Article : WebObject
    {
        public Article(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement ArticleDataTab
        {
            get
            {
                return
                    Driver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Artikel']"));
            }
        }
    }
}
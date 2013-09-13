using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal
{
    public class Article : WebObject
    {
        public IWebElement ArticleDataTab
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Artikel']"));
            }
        }
    }
}
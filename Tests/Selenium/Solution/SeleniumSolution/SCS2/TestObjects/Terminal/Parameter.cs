using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal
{
    public class Parameter : WebObject
    {
        public IWebElement ParameterDataTab
        {
            get
            {
                return
                    WebDriver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Parameter']"));
            }
        }
    }
}
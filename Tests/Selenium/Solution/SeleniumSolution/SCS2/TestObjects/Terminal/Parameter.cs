using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class Parameter : WebObject
    {
        public Parameter(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement ParameterDataTab
        {
            get
            {
                return
                    Driver.FindElement(
                        By.PartialLinkText(
                            "span#ctl00_bodyContentPlaceHolder_tbcTerminalData td.tab[textContent='Parameter']"));
            }
        }
    }
}
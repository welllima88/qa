using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.TestObjects;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal.Dashboard
{
    /// <summary>
    /// Terminal info object that represent the fix part in terminal dash board which shows terminal infos
    /// </summary>
    public class TerminalInfo : WebObject
    {
        public TerminalInfo(IWebDriverAdapter driver) : base(driver)
        {
        }

        public string TerminalId
        {
            get { return Driver.FindElement(By.CssSelector("div.portletSummaryColumn #TD_Trm_TID")).Text; }
        }

        public string ExternTerminalId
        {
            get { return Driver.FindElement(By.CssSelector("div.portletSummaryColumn #TD_Trm_ExtId")).Text; }
        }

        public string Article
        {
            get { return Driver.FindElement(By.CssSelector("div.portletSummaryColumn #TD_Trm_ArticleDisplayName")).Text; }
        }

        public string Status
        {
            get { return Driver.FindElement(By.CssSelector("div.portletSummaryColumn #TD_Trm_State")).Text; }
        }
    }
}
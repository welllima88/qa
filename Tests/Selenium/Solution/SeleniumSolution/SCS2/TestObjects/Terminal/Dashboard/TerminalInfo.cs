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
            get { return Driver.FindElement(By.CssSelector(Dashboard.TerminalInfo_TerminalId)).Text; }
        }

        public string ExternTerminalId
        {
            get { return Driver.FindElement(By.CssSelector(Dashboard.TerminalInfo_ExternTerminalId)).Text; }
        }

        public string Article
        {
            get { return Driver.FindElement(By.CssSelector(Dashboard.TerminalInfo_Article)).Text; }
        }

        public string Status
        {
            get { return Driver.FindElement(By.CssSelector(Dashboard.TerminalInfo_Status)).Text; }
        }
    }
}
using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Terminal.Dashboard
{
    /// <summary>
    ///     Terminal info object that represent the fix part in terminal dash board which shows terminal infos
    /// </summary>
    public class TerminalInfo : WebObject
    {
        public IWebElementAdapter TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_TerminalId)); }
        }

        public IWebElementAdapter ExternTerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_ExternTerminalId)); }
        }

        public IWebElementAdapter Article
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_Article)); }
        }

        public IWebElementAdapter Status
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_Status)); }
        }
    }
}
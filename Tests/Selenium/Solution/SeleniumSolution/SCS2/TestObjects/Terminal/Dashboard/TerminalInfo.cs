using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

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

        public IWebElementAdapter TerminalId
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_TerminalId)); }
        }

        public IWebElementAdapter ExternTerminalId
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_ExternTerminalId)); }
        }

        public IWebElementAdapter Article
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_Article)); }
        }

        public IWebElementAdapter Status
        {
            get { return Driver.FindAdaptedElement(By.CssSelector(Dashboard.TerminalInfo_Status)); }
        }
    }
}
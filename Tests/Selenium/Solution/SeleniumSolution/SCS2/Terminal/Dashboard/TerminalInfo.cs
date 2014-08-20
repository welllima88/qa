using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Terminal.Dashboard
{
    /// <summary>
    ///     Terminal info object that represent the fix part in terminal dash board which shows terminal infos
    /// </summary>
    public class TerminalInfo : WebObject
    {
        public static string TerminalId
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_TerminalId)).Text; }
        }

        public static string ExternTerminalId
        {
            get
            {
                return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_ExternTerminalId)).Text;
            }
        }

        public static string Article
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector(DashboardRes.TerminalInfo_Article)).Text; }
        }

        public static string Status
        {
            get { return WebDriver.FindAdaptedElement(By.Id("TD_Trm_State")).Text; }
        }

        public static IWebElementAdapter Cancelled
        {
            get { return WebDriver.FindAdaptedElement(By.CssSelector("div#DashboardSummaryContainer div.canceledTerminal")); }
        }
    }
}
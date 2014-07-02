using OpenQA.Selenium;
using Six.Scs.QA.Selenium.Extension.WebDriver.WebElements;

namespace Six.Scs.QA.Selenium.Extension.TestObjects.Common.Menu
{
    public class TerminalAnalysisMenu : WebObject
    {
        public static IWebElement TerminalAnalysis
        {
            /*
            * no href attribute at this node, alternatively use xpath (kind of best worst case) and this is probably seldom used in tests
            * throw new NotImplementedException();
            * return WebDriver.FindElement(By.CssSelector("a[href*='/Contract/ContractNew.aspx?TERMINALID=']"));
            */
            get { return WebDriver.FindElement(By.XPath("//td[text()='Terminal-Analyse']")); }
        }

        public static IWebElement GklpBlock
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_GklpBlock)); }
        }

        public static IWebElement SetFastInit
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_SetFastInit)); }
        }

        public static IWebElement ResetComAdresses
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_ResetComAdresses)); }
        }

        public static IWebElement TerminalEvents
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_TerminalEvents)); }
        }

        public static IWebElement FoMessages
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_FoMessages)); }
        }

        public static IWebElement FoQueries
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_FoQueries)); }
        }

        public static IWebElement Ep2TraceLog
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_Ep2TraceLog)); }
        }

        public static IWebElement SendOverview
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_SendOverview)); }
        }
    }
}
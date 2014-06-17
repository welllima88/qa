using OpenQA.Selenium;

namespace Six.Scs.Tests.Selenium.Extension.TestObjects.Common.Menu
{
    public class TerminalAnalysisMenu : MenuObject
    {
        public IWebElement TerminalAnalysis
        {
            /*
            * no href attribute at this node, alternatively use xpath (kind of best worst case) and this is probably seldom used in tests
            * throw new NotImplementedException();
            * return WebDriver.FindElement(By.CssSelector("a[href*='/Contract/ContractNew.aspx?TERMINALID=']"));
            */
            get { return WebDriver.FindElement(By.XPath("//td[text()='Terminal-Analyse']")); }
        }

        public IWebElement GklpBlock
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_GklpBlock)); }
        }

        public IWebElement SetFastInitFlag
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_SetFastInitFlag)); }
        }

        public IWebElement ResetComAdresses
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_ResetComAdresses)); }
        }

        public IWebElement TerminalEvents
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_TerminalEvents)); }
        }

        public IWebElement FoMessages
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_FoMessages)); }
        }

        public IWebElement FoQueries
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_FoQueries)); }
        }

        public IWebElement Ep2TraceLog
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_Ep2TraceLog)); }
        }

        public IWebElement SendOverview
        {
            get { return WebDriver.FindElement(By.CssSelector(MenuRes.TerminalAnalysisMenu_SendOverview)); }
        }
    }
}
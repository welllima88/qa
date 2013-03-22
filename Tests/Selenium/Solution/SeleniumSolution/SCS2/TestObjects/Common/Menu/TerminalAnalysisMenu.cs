using OpenQA.Selenium;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Common.Menu
{
    public class TerminalAnalysisMenu : MenuObject
    {
        public TerminalAnalysisMenu(IWebDriverAdapter driver) : base(driver)
        {
        }

        public IWebElement TerminalAnalysis
        {
            /*
            * no href attribute at this node, alternatively use xpath (kind of best worst case) and this is probably seldom used in tests
            * throw new NotImplementedException();
            * return Driver.FindElement(By.CssSelector("a[href*='/Contract/ContractNew.aspx?TERMINALID=']"));
            */
            get { return Driver.FindElement(By.XPath("//td[text()='Terminal-Analyse']")); }
        }

        public IWebElement GklpBlock
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_GklpBlock)); }
        }

        public IWebElement SetFastInitFlag
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_SetFastInitFlag)); }
        }

        public IWebElement ResetComAdresses
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_ResetComAdresses)); }
        }

        public IWebElement TerminalEvents
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_TerminalEvents)); }
        }

        public IWebElement FoMessages
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_FoMessages)); }
        }

        public IWebElement FoQueries
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_FoQueries)); }
        }

        public IWebElement Ep2TraceLog
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_Ep2TraceLog)); }
        }

        public IWebElement SendOverview
        {
            get { return Driver.FindElement(By.CssSelector(Menu.TerminalAnalysisMenu_SendOverview)); }
        }
    }
}
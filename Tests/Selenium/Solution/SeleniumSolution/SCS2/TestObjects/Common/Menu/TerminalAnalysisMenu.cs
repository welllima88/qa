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
            get { return Driver.FindElement(By.CssSelector("a[href*='/GKLP/GKLPBlock.aspx?TERMINALID=']")); }
        }

        public IWebElement SetFastInitFlag
        {
            get
            {
                return
                    Driver.FindElement(
                        By.CssSelector(
                            "a[href*='/TerminalFastInitFlag.asp?mode=TerminalFastInitFlagCommit&TERMINALID=']"));
            }
        }

        public IWebElement ResetComAdresses
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/ResetNetAddr.aspx?TERMINALID=']")); }
        }

        public IWebElement TerminalEvents
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TerminalS3Log.asp?TERMINALID=']")); }
        }

        public IWebElement FoMessages
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/FoMessage/Index?TERMINALID=']")); }
        }

        public IWebElement FoQueries
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/Terminal/FOQueries.aspx?TERMINALID=']")); }
        }

        public IWebElement Ep2TraceLog
        {
            get { return Driver.FindElement(By.CssSelector("a[href*='/TerminalEP2Log.asp?TERMINALID=']")); }
        }

        public IWebElement SendOverview
        {
            get
            {
                return
                    Driver.FindElement(By.CssSelector("a[href*='/Admin/MessageTransport/Overview.aspx?TERMINALID=']"));
            }
        }
    }
}
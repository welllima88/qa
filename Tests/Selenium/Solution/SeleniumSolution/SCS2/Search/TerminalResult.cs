namespace Six.Scs.QA.Selenium.Search
{
    public class TerminalResult : SearchDivLocator
    {
        public override string ResultId
        {
            get { return "terminalResult"; }
        }

        public override string LinkPart
        {
            get { return "/TerminalDashboard/?terminalId="; }
        }

        public override string Section
        {
            get { return "terminalDiv"; }
        }
    }
}
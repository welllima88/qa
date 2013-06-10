using System;
using SIX.SCS.QA.Selenium.Extension;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Terminal
{
    public class Terminal : WebObject
    {
        public Terminal(IWebDriverAdapter driver) : base(driver)
        {
        }

        private string Name { get; set; }

        private string SAPNo { get; set; }

        private string SBS_Adress { get; set; }

        private string SBS_Curr { get; set; }

        private string SBS_Debit { get; set; }

        private string SupportContract { get; set; }

        private string WesClient { get; set; }

        private String[] Parameters { get; set; }

        private string TerminalType { get; set; }

        private string NetType { get; set; }

        private string MCC { get; set; }

        private string Mandant { get; set; }
    }
}
using System.Collections.Generic;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface IArticle
    {
        string Name { get; set; }
        bool Status { get; set; }
        string TerminalType { get; set; }
        string NetType { get; set; }
        string SbsArticleNumber { get; set; }
        string CashIntegrated { get; set; }
        List<string> Supplier { get; }
    }
}
using System.Collections.Generic;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface IArticle
    {
        string Name { get; }
        bool Status { get; }
        string NetType { get; }
        string SbsArticleNumber { get; }
        string CardReaderType { get; }
        string ContactlessIndicator { get; }
        string PosInterface { get; }
        string Color { get; }
        string SoftwareId { get; }
        string TrxSubmLim { get; }
        string TrxTransLim { get; }
        List<string> Supplier { get; }
        string RecallInterval { get; }
    }
}
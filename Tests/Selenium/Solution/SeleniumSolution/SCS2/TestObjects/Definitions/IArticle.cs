using System.Collections;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
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
        string RecallInterval { get; }
        ICollection Supplier { get; }
    }
}
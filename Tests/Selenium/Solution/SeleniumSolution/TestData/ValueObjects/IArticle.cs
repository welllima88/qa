using System.Collections;

namespace TestData.ValueObjects
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
namespace TestData.ValueObjects
{
    public interface ISimCardElement
    {
        string NetProvider { get; set; }
        string SimCardNumber { get; set; }
        string MobileNumber { get; set; }
        string Pin { get; set; }
        string Puk { get; set; }
        bool Status { get; set; }
        string TerminalId { get; set; }
        string Region { get; set; }
        string Usage { get; set; }
    }
}
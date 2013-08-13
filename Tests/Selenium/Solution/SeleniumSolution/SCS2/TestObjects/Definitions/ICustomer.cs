namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface ICustomer : IAdress, ILocation
    {
        string CustomerName { set; get; }
        string Supplier { get; set; }
        string CustomerNumber { get; }
        string SbsCurrency { get; set; }
        string SbsBillingTenant { get; set; }
        string CashIntegrator { set; get; }
        string CategoryCode { set; get; }
        string Agency { set; get; }
        string SupportContract { set; get; }
        string Segment { set; get; }
    }
}
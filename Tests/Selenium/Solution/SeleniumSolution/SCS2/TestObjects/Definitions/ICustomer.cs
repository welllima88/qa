namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface ICustomer
    {
        string Guid { get; }
        string CustomerName { set; get; }
        string SapNumber { set; get; }
        string CompanyName { set; get; }
        string Supplier { get; set; }
        string CustomerNumber { get; }
        string SbsDebitNumber { get; }
        string SbsAdressNumber { get; }
        string SbsCurrency { get; set; }
        string SbsBillingTenant { get; set; }
        string Ep2MerchantId { get; set; }
        string CashIntegrator { set; get; }
        string CategoryCode { set; get; }
        string Agency { set; get; }
        string SupportContract { set; get; }
        string StreetNo { set; get; }
        string Language { set; get; }
        string Country { set; get; }
        string Zip { set; get; }
        string City { set; get; }
        string AdressAddition { set; get; }
        string Po { set; get; }
        string Region { set; get; }
        string Telephone { set; get; }
        string Mobile { set; get; }
        string Fax { set; get; }
        string Email { set; get; }
        string Web { set; get; }
        string Segment { set; get; }
    }
}
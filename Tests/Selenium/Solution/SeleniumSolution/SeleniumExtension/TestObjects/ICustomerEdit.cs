using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface ICustomerEdit
    {
        string CustomerName { set; get; }
        string SapNumber { set; get; }
        string CompanyName { set; get; }
        string Supplier { get; }
        string CustomerNumber { get; }
        string SbsDebitNumber { get; }
        string SbsAdressNumber { get; }
        string SbsCurrency { get; }
        string SbsBillingTenant { get; }
        string Ep2MerchantId { get; }
        string CashIntegrator { set; get; }
        string CategoryCode { set; get; }
        string Agency { set; get; }
        string SupportContract { set; get; }
        string StreetName { set; get; }
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
        IWebElement SaveButton { get; }
        IWebElement CancelButton { get; }
    }
}
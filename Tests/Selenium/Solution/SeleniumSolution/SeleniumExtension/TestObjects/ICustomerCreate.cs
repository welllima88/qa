using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface ICustomerCreate
    {
        string Country { set; }
        string SbsBillingTenant { set; }
        string Zip { set; }
        string City { set; }
        string AdressAddition { set; }
        string Po { set; }
        string Region { set; }
        string Telephone { set; }
        string Mobile { set; }
        string Fax { set; }
        string Email { set; }
        string CustomerName { set; }
        string SapNumber { set; }
        string CompanyName { set; }
        string Supplier { set; }
        string SbsCurrency { set; }
        string CategoryCode { set; }
        string Agency { set; }
        string SupportContract { set; }
        string StreetName { set; }
        string Language { set; }
        string Web { set; }
        IWebElement CancelButton { get; }
        IWebElement SaveButton { get; }
        string CustomerNumber { set; }
        string CashIntegrator { set; }
        string Segment { set; }
    }
}
using System;
using OpenQA.Selenium;

namespace SIX.SCS.QA.Selenium.Extension.TestObjects
{
    public interface ICustomerView
    {
        string CompanyName { get; }
        string Guid { get; }
        string CustomerName { get; }
        string Supplier { get; }
        string SbsBillingTenant { get; }
        string StreetName { get; }
        string Zip { get; }
        string City { get; }
        string SbsCurrency { get; }
        String CustomerNumber { get; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        String Agency { get; }
        string Language { get; }
        string Country { get; }
        string Ep2MerchantId { get; }
        string Po { get; }
        string AdressAddition { get; }
        string SapNumber { get; }

        string Email { get; }

        string Telephone { get; }
        string Mobile { get; }
        string Fax { get; }
        string Web { get; }
        IWebElement EditButton { get; }
        string Region { get; }
        string CategoryCode { get; }
        string SupportContract { get; }
        string CashIntegrator { get; }
        string Segment { get; }
    }
}
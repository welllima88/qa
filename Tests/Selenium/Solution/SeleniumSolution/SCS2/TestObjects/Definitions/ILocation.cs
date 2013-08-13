using System;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface ILocation:IAdress
    {
        string CompanyName { get; }
        string Guid { get; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        string Language { get; }
        string Ep2MerchantId { get; }
        string SapNumber { get; }
        string Email { get; }
        string Web { get; }
        string Telephone { get; }
        string Mobile { get; }
        string Fax { get; }        
    }
}
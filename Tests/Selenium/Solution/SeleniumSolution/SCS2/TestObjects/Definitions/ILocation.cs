using System;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
{
    public interface ILocation : IContact, IAdress
    {
        string CompanyName { get; set; }
        string Guid { get; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        string Ep2MerchantId { get; set; }
        string SapNumber { get; set; }
    }
}
using System;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin.TestObjects.Definitions
{
    public interface ILocation : IContact, IAdress
    {
        string CompanyName { get; }
        string Guid { get; }
        String SbsDebitNumber { get; }
        String SbsAdressNumber { get; }
        string Ep2MerchantId { get; }
        string SapNumber { get; }
    }
}
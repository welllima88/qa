using System;

namespace SIX.SCS.QA.SCSPlatin.Tests.Selenium.TestObjects.Definitions
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
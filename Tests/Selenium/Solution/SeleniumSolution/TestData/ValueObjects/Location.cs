using System;

namespace Six.Scs.QA.TestData.ValueObjects
{
    public class Location
    {
        public Contact Contact { get; set; }
        public Adress Adress { get; set; }
        public string CompanyName { get; set; }
        public string Guid { get; set; }
        public String SbsDebitNumber { get; set; }
        public String SbsAdressNumber { get; set; }
        public string Ep2MerchantId { get; set; }
        public string SapNumber { get; set; }
    }
}
using System;

namespace Six.Scs.QA.Selenium.Extension.TestData.ValueObjects
{
    public class LocationData
    {
        public ContactData Contact { get; set; }
        public AdressData Adress { get; set; }
        public string CompanyName { get; set; }
        public string Guid { get; set; }
        public String SbsDebitNumber { get; set; }
        public String SbsAdressNumber { get; set; }
        public string Ep2MerchantId { get; set; }
        public string SapNumber { get; set; }
    }
}
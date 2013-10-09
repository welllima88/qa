using System;
using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.Worklow
{
    public class CustomerCreator : ICustomer
    {
        public CustomerCreator()
        {
            var dt = DateTime.Now.Ticks; //timestamp for each test

            Supplier = "SIX Payment Services AG";
            SbsCurrency = "EUR";
            SbsBillingTenant = "SIX Payment Services (Europe)";
            CustomerName = "SYR Kunde" + dt;
            CategoryCode = "3364: AGENCY RENT-A-CAR";
            SupportContract = "ServicePaket Top Account - St�rungsbehebung vor Ort Mo-So 5h";
            CashIntegrator = "Wincor Nixdorf AG, Br�ttisellen";
            Segment = "01_CH";
            CompanyName = "SYR Sele Firma A";
            StreetNo = "Hardturmstr. 201";
            Agency = "B05 Leiser Peter";
            Zip = "8021";
            City = "Z�rich";
            Po = "PFO1";
            AdressAddition = "Etage 3";
            Region = "Reg 3";
            SapNumber = "4440";
            Language = "Deutsch [de]";
            Country = "Schweiz [CH]";
            Email = "marc.siegmund@six-group.com";
            Telephone = "0031 58 399 6237";
            Mobile = "0032 58 399 6237";
            Fax = "0033 58 399 6237";
            Web = "www.six-group.com/de-intern";
        }

        public string Language { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string StreetNo { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string AdressAddition { get; set; }
        public string Po { get; set; }
        public string Region { get; set; }
        public string CompanyName { get; set; }
        public string Guid { get; private set; }
        public string SbsDebitNumber { get; set; }
        public string SbsAdressNumber { get; set; }
        public string Ep2MerchantId { get; set; }
        public string SapNumber { get; set; }
        public string CustomerName { get; set; }
        public string Supplier { get; set; }
        public string CustomerNumber { get; set; }
        public string SbsCurrency { get; set; }
        public string SbsBillingTenant { get; set; }
        public string CashIntegrator { get; set; }
        public string CategoryCode { get; set; }
        public string Agency { get; set; }
        public string SupportContract { get; set; }
        public string Segment { get; set; }
    }
}
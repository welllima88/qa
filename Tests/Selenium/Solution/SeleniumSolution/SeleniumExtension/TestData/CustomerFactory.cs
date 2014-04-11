using SIX.SCS.QA.Selenium.Extension.TestObjects.Definitions;

namespace SIX.SCS.QA.Selenium.Extension.TestData
{
    public class CustomerFactory
    {
        public CustomerData SixCustomerNew()
        {
            return new CustomerData
                {
                    Supplier = "SIX Payment Services AG",
                    SbsCurrency = "Euro",
                    SbsBillingTenant = "SIX Payment Services (Europe)",
                    CustomerName = "SYR Kunde" + Factory.GenerateTestId(),
                    CategoryCode = "3364: AGENCY RENT-A-CAR",
                    SupportContract = "ServicePaket Top Account - Störungsbehebung vor Ort Mo-So 5h",
                    CashIntegrator = "Wincor Nixdorf AG, Brüttisellen",
                    Segment = "01_CH",
                    CompanyName = "SYR Sele Firma A",
                    StreetNo = "Hardturmstr. 201",
                    Agency = "B05 Leiser Peter",
                    Zip = "8021",
                    City = "Zürich",
                    Po = "PFO1",
                    AdressAddition = "Etage 3",
                    Region = "Reg 3",
                    SapNumber = "4440",
                    Ep2MerchantId = "",
                    Language = "Deutsch [de]",
                    Country = "Schweiz [CH]",
                    Email = "marc.siegmund@six-group.com",
                    Telephone = "0031 58 399 6237",
                    Mobile = "0032 58 399 6237",
                    Fax = "0033 58 399 6237",
                    Web = "www.six-group.com/de-intern"
                };
        }

        public CustomerData SixCustomerEdit()
        {
            return new CustomerData
                {
                    CustomerName = "SYR Kunde" + Factory.GenerateTestId(),
                    CompanyName = "SYR Sele Firma A",
                    StreetNo = "Hardturmstr. 201",
                    Zip = "8021",
                    City = "Zürich",
                    Po = "PFO1",
                    AdressAddition = "Etage 3",
                    Region = "Reg 55",
                    SapNumber = "5440",
                    Agency = "SIX Payment Services (Europe)",
                    Language = "Deutsch [de]",
                    Country = "Schweiz [CH]",
                    Email = "marc.siegmund@six-group.com",
                    Telephone = "0031 58 399 6237",
                    Mobile = "0032 58 399 6237",
                    Fax = "0033 58 399 6237",
                    Web = "www.six-group.com/de-intern"
                };
        }

        public CustomerData InvalidCustomer()
        {
            return new CustomerData
                {
                    Supplier = "SIX Payment Services AG",
                    SbsCurrency = "EUR",
                    SbsBillingTenant = "SIX Payment Services (Europe)",
                    CustomerName = "SYR Sele Kunde A$°",
                    CompanyName = "SYR Sele Firma A$°",
                    CustomerNumber = "^@}$°",
                    StreetNo = "Hardturmstr. 201$°",
                    Zip = "802$°",
                    City = "Zürich$°",
                    Po = "PFO1$°",
                    AdressAddition = "Etage 3$°",
                    Region = "Reg 3[]$°",
                    SapNumber = "444$°",
                    Ep2MerchantId = "12DDFF_3-3",
                    Agency = "Albert Brun & Partner",
                    Language = "Deutsch [de]",
                    Country = "Schweiz [CH]",
                    Email = "marc.siegmund@six-grou$°p.com",
                    Telephone = "0031 58 399 6237$",
                    Mobile = "0032 58 399 6237$",
                    Fax = "0033 58 399 6237$",
                    Web = "www.six-^°@}$.com/de-inte[]rn$°"
                };
        }
    }
}
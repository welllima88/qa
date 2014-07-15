using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Brand;
using Six.Scs.QA.TestData.ValueObjects;

namespace Six.Scs.QA.Testlogic
{
    public class Brands
    {
        public static void Create(string terminalId)
        {
            Terminal.Open(new TerminalData {Id = terminalId});

            CreateAndSaveBrands();
        }

        private static void CreateAndSaveBrands()
        {
            BrandPortlet.NewBrandButton.Click();
// BrandSelect.Acquirer("SIX Payment Services").Brand("1161").Brand("877").Brand("1076").Select();
            BrandSelect.Select("283");
            BrandSelect.Select("332");
            BrandSelect.Select("361");
            BrandSelect.Select("363");
            BrandSelect.Select("811");
            BrandSelect.Deselect("1161");

            BrandSelect.ConfirmButton().Click();

            AcquirerCreate.Remark = "SYR Contracts";
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // BrandCreate.
        }

        public static void Create(TerminalData terminal)
        {
            Terminal.Open(terminal);
            CreateAndSaveBrands();
        }
    }
}
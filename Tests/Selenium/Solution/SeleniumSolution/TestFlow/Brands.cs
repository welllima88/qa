using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand;

namespace Six.Scs.QA.Testlogic
{
    public class Brands
    {
        public static void Create(string terminalId)
        {
            Terminal.Open(new TestData.ValueObjects.Terminal {Id = terminalId});

            CreateAndSaveBrands();
        }

        private static void CreateAndSaveBrands()
        {
            BrandPortlet.NewBrandButton.Click();
            Selection.Open("acq_post");
            Selection.Select("283");

            Selection.Open("acq_multipay");
            Selection.Select("1161");
            Selection.Select("332");
            Selection.Select("361");
            Selection.Select("363");
            Selection.Select("811");
            Selection.Deselect("1161");

            Selection.Open("acq_amexco");
            Selection.Select("635");

            Selection.ConfirmButton().Click();

            AcquirerCreate.Remark = "SYR Contracts" +TestData.Factory.Factory.GenerateTestId;
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // BrandCreate.
        }

        public static void Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            CreateAndSaveBrands();
        }
    }
}
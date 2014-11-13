using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.QA.TestData.Factory;

namespace Six.Scs.QA.Testlogic
{
    public class Brands
    {
        private static void CheckBrands()
        {
            ContractsExist();
            TicketsCreated();
        }

        private static void TicketsCreated()
        {
            Console.Out.WriteLine(@"Checking Tickets");
        }

        private static void ContractsExist()
        {
            Assert.IsTrue(BrandPortlet.Available());

            Assert.IsTrue(BrandPortlet.Acquirer("acq_post").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("283").Displayed);
            Assert.IsTrue(BrandPortlet.Acquirer("acq_multipay").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("332").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("361").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("363").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("811").Displayed);
            Assert.IsTrue(BrandPortlet.Acquirer("acq_amexco").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("635").Displayed);
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

            AcquirerCreate.Remark = "SYR Contracts" + Factory.GenerateTestId();
            AcquirerCreate.SaveAndCreate();
            // TODO: more special settings for brands
            // BrandCreate.
        }

        public static void Create(TestData.ValueObjects.Terminal terminal)
        {
            Terminal.Open(terminal);
            CreateAndSaveBrands();
            CheckBrands();
        }
    }
}
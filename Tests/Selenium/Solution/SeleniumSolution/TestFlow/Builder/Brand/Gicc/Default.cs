using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.QA.TestData.Factory;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Brand.Gicc
{
    public class Default : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            // Assert.IsTrue(BrandPortlet.Acquirer("acq_multipayIntl").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("738").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("736").Displayed);

            // Assert.IsTrue(BrandPortlet.Acquirer("acq_streamline").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("406").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("934").Displayed);
        }

        protected override void SetBrandDetails()
        {
            AcquirerCreate.Remark = "SYR GICC Contracts" + Factory.GenerateTestId();
        }

        protected override void ChooseBrands()
        {
            Selection.Open("acq_multipayIntl");
            Selection.Select("738");
            Selection.Select("736");

            Selection.Open("acq_streamline");
            Selection.Select("406");
            Selection.Select("934");
        }
    }
}
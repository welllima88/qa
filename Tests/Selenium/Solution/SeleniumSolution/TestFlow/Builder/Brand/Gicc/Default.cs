using System;
using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Brand.Gicc
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
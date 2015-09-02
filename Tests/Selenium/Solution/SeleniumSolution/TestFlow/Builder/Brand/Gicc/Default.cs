using System;
using NUnit.Framework;
using Six.Scs.Test.UI.Contract;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets.Brand;
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
            // Assert.That(BrandPortlet.Acquirer("acq_multipayIntl").Displayed);
            Assert.That(BrandPortlet.Brand("738").Displayed);
            Assert.That(BrandPortlet.Brand("736").Displayed);

            // Assert.That(BrandPortlet.Acquirer("acq_streamline").Displayed);
            Assert.That(BrandPortlet.Brand("406").Displayed);
            Assert.That(BrandPortlet.Brand("934").Displayed);
        }

        protected override void SetBrandDetails()
        {
            UI.Contract.Acquirer.Create.Remark = "SYR GICC Contracts" + Factory.Base.GenerateTestId();
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
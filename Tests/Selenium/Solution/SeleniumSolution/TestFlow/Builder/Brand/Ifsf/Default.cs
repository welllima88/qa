using System;
using NUnit.Framework;
using Six.Scs.Test.Model.Factory;
using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Brand.Ifsf
{
    public class Default : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.That(BrandPortlet.Acquirer("acq_post").Displayed);
            Assert.That(BrandPortlet.Brand("283").Displayed);

            Assert.That(BrandPortlet.Acquirer("acq_multipay").Displayed);
            Assert.That(BrandPortlet.Brand("750").Displayed);
            Assert.That(BrandPortlet.Brand("752").Displayed);
            Assert.That(BrandPortlet.Brand("938").Displayed);
            Assert.That(BrandPortlet.Brand("754").Displayed);
        }

        protected override void SetBrandDetails()
        {
            AcquirerCreate.Remark = "SYR IFSF Contracts" + Factory.GenerateTestId();
            AcquirerCreate.DccProvider = "SIX Payment Services";
        }

        protected override void ChooseBrands()
        {
            Selection.Open("acq_post");
            Selection.Select("283");

            Selection.Open("acq_multipay");
            Selection.Select("750");
            Selection.Select("752");
            Selection.Select("938");
            Selection.Select("754");
            Selection.Select("948");
            Selection.Deselect("948");
        }
    }
}
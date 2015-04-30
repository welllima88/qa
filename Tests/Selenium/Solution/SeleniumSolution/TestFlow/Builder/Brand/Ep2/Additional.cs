using System;
using NUnit.Framework;
using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Brand.Ep2
{
    public class Additional : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.IsTrue(BrandPortlet.Acquirer("acq_corner").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1286").Displayed);

            Assert.IsTrue(BrandPortlet.Acquirer("acq_concardisfirstdata").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1272").Displayed);

            Assert.IsTrue(BrandPortlet.Acquirer("acq_commtrain").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1114").Displayed);
        }

        protected override void SetBrandDetails()
        {
        }

        protected override void ChooseBrands()
        {
            Selection.Open("acq_corner");
            Selection.Select("1286");

            Selection.Open("acq_concardisfirstdata");
            Selection.Select("1272");

            Selection.Open("acq_commtrain");
            Selection.Select("1114");
        }
    }
}
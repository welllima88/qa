using System;
using NUnit.Framework;
using Six.Scs.Test.View.Brand;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Brand.ELink
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
            Assert.IsTrue(BrandPortlet.Brand("1091").Displayed);

            // Assert.IsTrue(BrandPortlet.Acquirer("acq_multipay").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("682").Displayed);

            // Assert.IsTrue(BrandPortlet.Acquirer("acq_amexco").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1284").Displayed);
        }

        protected override void SetBrandDetails()
        {
        }

        protected override void ChooseBrands()
        {
            Selection.Open("acq_multipayIntl");
            Selection.Select("1091");

            Selection.Open("acq_multipay");
            Selection.Select("682");

            Selection.Open("acq_amexco");
            Selection.Select("1284");
        }
    }
}
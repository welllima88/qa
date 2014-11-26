using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Brand;
using Six.Scs.QA.Selenium.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.QA.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Brand.Ep2
{
    public class Additional : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.IsTrue(BrandPortlet.Acquirer("acq_multipay").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1161").Displayed);

            Assert.IsTrue(BrandPortlet.Acquirer("acq_epa").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("703").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("562").Displayed);

            Assert.IsTrue(BrandPortlet.Acquirer("acq_commtrain").Displayed);
            Assert.IsTrue(BrandPortlet.Brand("1114").Displayed);
        }

        protected override void SetBrandDetails()
        {
        }

        protected override void ChooseBrands()
        {
            Selection.Open("acq_multipay");
            Selection.Select("1161");

            Selection.Open("acq_epa");
            Selection.Select("703");
            Selection.Select("562");

            Selection.Open("acq_commtrain");
            Selection.Select("1114");
        }
    }
}
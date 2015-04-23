using System;
using NUnit.Framework;
using Six.Scs.QA.Selenium.Model.Factory;
using Six.Scs.QA.Selenium.View.Brand;
using Six.Scs.QA.Selenium.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.QA.Selenium.Workflow.Builder;

namespace Six.Scs.QA.Testlogic.Builder.Brand.Ep2
{
    public class Default : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
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

        protected override void SetBrandDetails()
        {
            AcquirerCreate.Remark = "SYR EP2 Contracts" + Factory.GenerateTestId();
        }

        protected override void ChooseBrands()
        {
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
        }
    }
}
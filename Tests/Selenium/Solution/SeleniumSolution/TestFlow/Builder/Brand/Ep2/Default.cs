using System;
using NUnit.Framework;
using Six.Scs.Test.View.Contract;
using Six.Scs.Test.View.Terminal.Dashboard.Portlets.Brand;
using Six.Scs.Test.Workflow.Builder;

namespace Six.Scs.Test.Builder.Brand.Ep2
{
    public class Default : BrandBuilder
    {
        public override void Edit()
        {
            throw new NotImplementedException();
        }

        public override void Check()
        {
            Assert.That(BrandPortlet.Acquirer("acq_post").Name, Is.EqualTo("Die Schweizerische Post"));
            Assert.That(BrandPortlet.Brand("283").Displayed);

            Assert.That(BrandPortlet.Acquirer("acq_multipay").Name, Is.EqualTo("SIX Payment Services"));
            Assert.That(BrandPortlet.Brand("332").Displayed);
            Assert.That(BrandPortlet.Brand("361").Displayed);
            Assert.That(BrandPortlet.Brand("363").Displayed);
            Assert.That(BrandPortlet.Brand("811").Displayed);

            Assert.That(BrandPortlet.Acquirer("acq_amexco").Name, Is.EqualTo("Swisscard"));
            Assert.That(BrandPortlet.Brand("635").Displayed);
        }

        protected override void SetBrandDetails()
        {
            View.Contract.Acquirer.Create.Remark = "SYR EP2 Contracts" + Factory.Base.GenerateTestId();
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
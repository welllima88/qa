using System;
using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.View.Contract;
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
            Assert.That(BrandPortlet.Acquirers().Contains("SIX Payment Services"));
            Assert.That(BrandPortlet.Brands().Where(s => s.Contains("1091")), Is.Not.Empty);

            Assert.That(BrandPortlet.Acquirers().Contains("SIX Payment Services (Europe)"));
            Assert.That(BrandPortlet.Brands().Where(s => s.Contains("682")), Is.Not.Empty);

            Assert.That(BrandPortlet.Acquirers().Contains("Swisscard"));
            Assert.That(BrandPortlet.Brands().Where(s => s.Contains("1284")), Is.Not.Empty);
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
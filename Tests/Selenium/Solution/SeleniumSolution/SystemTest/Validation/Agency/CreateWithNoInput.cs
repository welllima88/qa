using System.Linq;
using NUnit.Framework;
using Six.Scs.Test.UI.Administration.Agency;
using Six.Scs.Test.UI.Common;
using Six.Test.Selenium.WebDriver;
using List = Six.Scs.Test.UI.Administration.Agency.List;

namespace Six.Scs.Test.Validation.Agency
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreate()
        {
            TestDirector.Navigate("Agency/List");
            List.Create.Click();
            Create.SaveButton.Click();
        }

        [Test]
        public void City()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("Agency.City"));
        }

        [Test]
        public void Name()
        {
            Assert.That(FormAlert.InvalidElementNames.Contains("Agency.AgencyName"));
        }
    }
}
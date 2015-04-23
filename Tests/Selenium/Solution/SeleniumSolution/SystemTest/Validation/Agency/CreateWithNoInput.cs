using System.Linq;
using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.View.Administration.Agency;
using Six.Scs.QA.Selenium.View.Common;
using List = Six.Scs.QA.Selenium.View.Administration.Agency.List;

namespace Six.Scs.QA.Selenium.SystemTest.Validation.Agency
{
    [TestFixture]
    public class CreateWithNoInput
    {
        [TestFixtureSetUp]
        public void GoToCreateContact()
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
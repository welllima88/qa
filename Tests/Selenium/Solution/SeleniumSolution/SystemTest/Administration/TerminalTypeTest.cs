using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    public class TerminalTypeTest
    {
        [TestFixtureSetUp]
        public void Navigate()
        {
            TestDirector.Navigate("TerminalType?TerminalTypeId=1025");
            _originTerminalType = TerminalType.View();
        }

        [TestFixtureTearDown]
        public void Restore()
        {
            TerminalType.Edit(_originTerminalType);
        }

        private Model.ValueObjects.TerminalType _terminalType;
        private Model.ValueObjects.TerminalType _originTerminalType;

        [Test]
        [Category("TerminalType"), Category("View"), Category("Edit")]
        public void EditTerminalType()
        {
            _terminalType = Model.Factory.TerminalType.XentissimoMod();
            // use existin configuration (for checking), due to UI problems:
            _terminalType.Providers = _originTerminalType.Providers;
            _terminalType.Suppliers = _originTerminalType.Suppliers;

            _terminalType = TerminalType.Edit(_terminalType);
        }
    }
}
using System.Linq;
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

            _terminalType = Model.Factory.TerminalType.XentissimoMod();
            // use existin configuration (for checking), due to UI problems:
            _terminalType.Providers = _originTerminalType.Providers;
            _terminalType.SoftwareIds = _originTerminalType.SoftwareIds;
            _terminalType.Suppliers = _originTerminalType.Suppliers;
            _terminalType.Range = _originTerminalType.Range;
        }

        [TestFixtureTearDown]
        public void Restore()
        {
            _terminalType = Model.Factory.TerminalType.XentissimoOrigin();
            // use existin configuration (for checking), due to UI problems:
            _terminalType.Providers = _originTerminalType.Providers;
            _terminalType.SoftwareIds = _originTerminalType.SoftwareIds;
            _terminalType.Suppliers = _originTerminalType.Suppliers;
            _terminalType.Range = _originTerminalType.Range;
            TerminalType.Edit(_terminalType);
        }

        private Model.ValueObjects.TerminalType _terminalType;
        private Model.ValueObjects.TerminalType _originTerminalType;

        [Test]
        [Category("TerminalType"), Category("View"), Category("Edit")]
        public void EditTerminalType()
        {
            TerminalType.Edit(_terminalType);
        }
    }
}
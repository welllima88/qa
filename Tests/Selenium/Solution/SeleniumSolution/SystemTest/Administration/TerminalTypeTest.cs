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
            _terminalType = TerminalType.Edit(_terminalType);
        }
    }
}
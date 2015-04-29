using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    public class TerminalTypeTest
    {
        [SetUp]
        public static void Navigate()
        {
            // open xentissimo
            TestDirector.Navigate("TerminalType?TerminalTypeId=1025");
        }

        private Model.ValueObjects.TerminalType _terminalType;
        private Model.ValueObjects.TerminalType _originTerminalType;

        [Test]
        [Category("TerminalType"), Category("Create"), Category("Edit"), Category("Deactivate")]
        public void EditTerminalType()
        {
            _originTerminalType = TerminalType.View();
            _terminalType = TerminalType.Edit(_terminalType);
            _terminalType = TerminalType.Edit(_originTerminalType); // restore state
        }
    }
}
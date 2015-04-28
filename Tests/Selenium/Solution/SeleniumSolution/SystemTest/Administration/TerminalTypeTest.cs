using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using Six.Scs.QA.Selenium.Model.ValueObjects;

namespace Six.Scs.QA.Selenium.SystemTest.Administration
{
    [TestFixture]
    public class TerminalTypeTest
    {
        [SetUp]
        public static void Navigate()
        {
            TestDirector.Navigate("TerminalType?TerminalTypeId=1025");
        }

        private TerminalType _terminalType;
        private TerminalType _originTerminalType;

        [Test]
        [Category("TerminalType"), Category("Create"), Category("Edit"), Category("Deactivate")]
        public void EditTerminalType()
        {
            _originTerminalType = Testlogic.Administration.TerminalType.View();
            _terminalType = Testlogic.Administration.TerminalType.Edit(_terminalType);
            _terminalType = Testlogic.Administration.TerminalType.Edit(_originTerminalType); // restore state
        }
    }
}
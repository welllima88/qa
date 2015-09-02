using NUnit.Framework;
using Six.Scs.Test.UI.Search;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    [Category("TerminalType"), Category("Search")]
    public class TerminalTypeTest
    {
        [TestFixtureSetUp]
        public void Navigate()
        {
            //TestDirector.Navigate("TerminalType?TerminalTypeId=1025");
            Workflow.Search.Find("1025");
            SearchResult.First(Result.TerminalType).Click();

            _originTerminalType = TerminalType.View();

            _terminalType = Factory.TerminalType.XentissimoMod();
            // use existing configuration (for checking), due to UI problems:
            _terminalType.Providers = _originTerminalType.Providers;
            _terminalType.SoftwareIds = _originTerminalType.SoftwareIds;
            _terminalType.Suppliers = _originTerminalType.Suppliers;
            _terminalType.Range = _originTerminalType.Range;
        }

        [TestFixtureTearDown]
        public void Restore()
        {
            _terminalType = Factory.TerminalType.XentissimoOrigin();
            // use existin configuration (for checking), due to UI problems:
            _terminalType.Providers = _originTerminalType.Providers;
            _terminalType.SoftwareIds = _originTerminalType.SoftwareIds;
            _terminalType.Suppliers = _originTerminalType.Suppliers;
            _terminalType.Range = _originTerminalType.Range;
            TerminalType.Edit(_terminalType);
        }

        private Model.TerminalType _terminalType;
        private Model.TerminalType _originTerminalType;

        [Test]
        [Category("TerminalType"), Category("View"), Category("Edit")]
        public void EditTerminalType()
        {
            TerminalType.Edit(_terminalType);
        }
    }
}
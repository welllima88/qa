using NUnit.Framework;
using Six.Scs.Test.UI.Terminal.Dashboard;
using Six.Scs.Test.UI.Terminal.Dashboard.Portlets;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Terminal
{
    /// <summary>
    ///     Quick open from Terminal Dashboard
    /// </summary>
    [TestFixture]
    public class QuickOpen
    {
        [SetUp]
        [Category("Search")]
        public static void ClassInit()
        {
            TestDirector.Navigate("TerminalDashboard/?TerminalId=30092755");
            PortletBase.AllHasBeenLoaded();
        }

        private static string _terminal;

        [Test]
        [Category("Search"), Category("Terminal")]
        public void Empty()
        {
            _terminal = "";
            UI.Terminal.Dashboard.Portlets.QuickOpen.OpenTerminalId = _terminal;

            Assert.That(UI.Terminal.Dashboard.Portlets.QuickOpen.Info, Is.EqualTo("Bitte geben Sie einen Wert ein"));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void IfsfGroupAndDeviceId()
        {
            _terminal = "06081588";
            UI.Terminal.Dashboard.Portlets.QuickOpen.OpenTerminalId = _terminal;
            
            Assert.That(TerminalInfo.ExternTerminalId, Is.EqualTo(_terminal));
            Assert.That(TerminalInfo.TerminalId, Is.EqualTo("21395264"));
            Assert.That(TerminalInfo.Article, Is.StringContaining("IFSF"));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void Ivalid()
        {
            _terminal = "654*-ç";
            UI.Terminal.Dashboard.Portlets.QuickOpen.OpenTerminalId = _terminal;

            Assert.That(UI.Terminal.Dashboard.Portlets.QuickOpen.Info,
                Is.EqualTo(string.Format("Es wurde nichts für die Suchanfrage '{0}' gefunden", _terminal)));
        }

        [Test]
        [Category("Search"), Category("Terminal")]
        public void ScsTerminalId()
        {
            _terminal = "30092755";
            UI.Terminal.Dashboard.Portlets.QuickOpen.OpenTerminalId = _terminal;

            Assert.That(TerminalInfo.TerminalId, Is.EqualTo(_terminal));
            Assert.That(TerminalInfo.ExternTerminalId, Is.EqualTo(_terminal));
        }
    }
}
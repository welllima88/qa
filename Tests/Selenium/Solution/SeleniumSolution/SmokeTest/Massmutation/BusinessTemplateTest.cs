using NUnit.Framework;
using Six.Scs.Test.UI.Massmuation;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Massmutation
{
    /// <summary>
    ///     be careful with menu expander because they prevent some actions and need special handling
    /// </summary>
    [TestFixture]
    [Category("BusinessTemplate")]
    [Category("Massmutation")]
    public class BusinessTemplateTest
    {
        private static string[] _terminalIds;

        [TestFixtureSetUp]
        public static void ClassInit()
        {
            TestDirector.Navigate("BusinessTemplate/Change");

            _terminalIds = new[] {"30092755", "30092756"};
            BusinessTemplate.TerminalIds = _terminalIds;
        }

        [Test]
        public void Acquirer()
        {
            Assert.That(BusinessTemplate.Acquirer, Is.EqualTo("SIX Payment Services"));
        }

        [Test]
        public void ActualBusinessTemplate()
        {
            Assert.That(BusinessTemplate.ActualBusinessTemplate, Is.EqualTo("0 - ohne Business-Template"));
        }

        [Test]
        public void NewBusinessTemplate()
        {
            Assert.That(BusinessTemplate.NewBusinessTemplate, Is.Not.Empty);
        }

        [Test]
        public void TerminalIds()
        {
            Assert.That(BusinessTemplate.TerminalIds, Is.Not.Empty);
        }
    }
}
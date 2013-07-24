using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSClassics.Settings;

namespace SIX.SCS.QA.Selenium.Tests.SCSClassics
{
    public class ScsClassicTestDirector : TestDirector
    {
        private readonly TestEnvironment _testEnvironment = new Prod();

        public override TestEnvironment TestEnvironment
        {
            get { return _testEnvironment; }
        }
    }
}
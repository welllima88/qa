using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    public class ScsPlatinTestDirector : TestDirector
    {
        private readonly TestEnvironment _testEnvironment = new Dev();

        public override TestEnvironment TestEnvironment
        {
            get { return _testEnvironment; }
        }
    }
}
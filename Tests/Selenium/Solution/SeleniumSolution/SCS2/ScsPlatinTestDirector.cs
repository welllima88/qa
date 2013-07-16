using Microsoft.VisualStudio.TestTools.UnitTesting;
using SIX.SCS.QA.Selenium.Extension;
using SIX.SCS.QA.Selenium.Extension.Settings;
using SIX.SCS.QA.Selenium.Tests.SCSPlatin.Settings;

namespace SIX.SCS.QA.Selenium.Tests.SCSPlatin
{
    [TestClass]
    public class ScsPlatinTestDirector : TestDirector
    {
        public override TestEnvironment TestEnvironment
        {
            get { return new Dev(); }
        }
    }
}
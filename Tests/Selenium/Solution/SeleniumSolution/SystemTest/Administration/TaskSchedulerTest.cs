using NUnit.Framework;
using Six.QA.Selenium.Extension.WebDriver;
using List = Six.Scs.QA.Selenium.Administration.TaskScheduler.List;

namespace Six.Scs.QA.Selenium.SystemTest.Administration
{
    [TestFixture]
    public class TaskSchedulerTest
    {
        [TestFixtureSetUp]
        public static void Navigate()
        {
            TestDirector.Navigate("TaskScheduler/");
        }

        [Test]
        [Category("TaskScheduler"), Category("Create"), Category("Edit"), Category("Delete")]
        public void Manage()
        {
            List.CreateTask.Click();
        }
    }
}
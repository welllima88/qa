using NUnit.Framework;
using Six.Scs.Test.Model.ValueObjects;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    [Category("TaskScheduler")]
    [Ignore]
    public class TasksSchedulerTest
    {
        private Task _task;

        [TestFixtureSetUp]
        public void ClassInit()
        {
            TestDirector.Navigate("TaskScheduler/TaskSchedulerAdministration");
        }

        [Test]
        [Category("Task"), Category("Edit"), Category("Create"), Category("Delete")]
        public void BatchCreateButton()
        {
            _task = TasksScheduler.Create();
            _task = TasksScheduler.Edit();
            TasksScheduler.Delete(_task);
        }
    }
}
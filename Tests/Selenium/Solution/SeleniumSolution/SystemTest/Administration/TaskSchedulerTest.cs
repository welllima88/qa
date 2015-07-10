using NUnit.Framework;
using Six.Test.Selenium.WebDriver;

namespace Six.Scs.Test.Administration
{
    [TestFixture]
    [Ignore("BUG: Der Wert NULL kann in die IsUpToDate-Spalte, mgmt.scs2.TaskScheduler-Tabelle nicht eingefügt werden")]
    public class TaskSchedulerTest
    {
        [TestFixtureSetUp]
        public static void Navigate()
        {
            TestDirector.Navigate("TaskScheduler/TaskSchedulerAdministration");
        }

        [Test]
        [Category("TaskScheduler"), Category("Create"), Category("Edit"), Category("Delete")]
        public void Manage()
        {
            TasksScheduler.Create();
            var t = TasksScheduler.Edit();
            TasksScheduler.Delete(t);
        }
    }
}
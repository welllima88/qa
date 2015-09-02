namespace Six.Scs.Test.Factory
{
    public class Task
    {
        public static Model.Task Create()
        {
            return new Model.Task
            {
                Arguments = "Arguments /-aa ? :XX01",
                Interval = "1",
                MachineName = "Machine_SYR_Auto1",
                MaxRetries = "11",
                Module = "Module A",
                RetryInterval = "2",
                TaskName = "Task SYR Auto A" + Base.GenerateTestId(),
                Type = "Executable",
                WaitOnShutdown = "22",
                WorkingDirectory = @"c:\create\\Task_SYR\HOME"
            };
        }

        public static Model.Task Edit()
        {
            return new Model.Task
            {
                Arguments = "Arguments /-bb ? :XX01",
                Interval = "2",
                MachineName = "Machine_SYR_Auto2",
                MaxRetries = "22",
                Module = "Module B",
                RetryInterval = "4",
                TaskName = "Task SYR Auto B" + Base.GenerateTestId(),
                Type = "IScheduledTask",
                WaitOnShutdown = "44",
                WorkingDirectory = @"c:\edit\\Task_SYR\HOME"
            };
        }
    }
}
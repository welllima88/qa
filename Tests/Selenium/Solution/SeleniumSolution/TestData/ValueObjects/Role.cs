using System.Collections.Generic;

namespace Six.Scs.QA.TestData.ValueObjects
{
    public class Role
    {
        public string Name { get; set; }
        public IEnumerable<Permission> Permissions { get; set; }
    }

    public class Permission
    {
        public string Name { get; set; }
        public Level Level { get; set; }
    }

    public enum Level
    {
    }
}
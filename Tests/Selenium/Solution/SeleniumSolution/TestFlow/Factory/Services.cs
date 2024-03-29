using System.Collections.Generic;
using System.Collections.ObjectModel;
using Six.Scs.Test.Model;

namespace Six.Scs.Test.Factory
{
    public static class Services
    {
        public static ICollection<Service> Scs()
        {
            return new Collection<Service>
            {
                new Service
                {
                    Name = "SCS2.0",
                    Permission = "SCS2 Dummy"
                },
                new Service
                {
                    Name = "Analyzer",
                    Permission = "Service Benutzer"
                }
            };
        }
    }
}
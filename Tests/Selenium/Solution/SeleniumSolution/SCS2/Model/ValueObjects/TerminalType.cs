using System.Collections.Generic;

namespace Six.Scs.Test.Model.ValueObjects
{
    public class TerminalType
    {
        public string DefaultAdditionalCapabilities;
        public string DefaultCapabilities;
        public string DeviceType;
        public string Range;
        public string ReferenceSystem;
        public string Supplier;
        public IEnumerable<string> Providers;
        public IEnumerable<string> Suppliers;
        public IEnumerable<string> SoftwareIds;
    }
}
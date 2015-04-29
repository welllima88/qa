using System.Collections.Generic;

namespace Six.Scs.Test.Model.ValueObjects
{
    public class TerminalType
    {
        public string DefaultAdditionalCapabilities;
        public string DefaultCapabilities;
        public string DeviceType;
        public IEnumerable<string> Providers;
        public string Range;
        public string ReferenceSystem;
        public IEnumerable<string> SoftwareIds;
        public string Supplier;
        public IEnumerable<string> Suppliers;
    }
}
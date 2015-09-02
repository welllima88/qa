namespace Six.Scs.Test.Factory
{
    public static class TerminalType

    {
        public static Model.TerminalType XentissimoMod()
        {
            return new Model.TerminalType
            {
                Supplier = "Alle Fremdhersteller",
                ReferenceSystem = "GICC",
                DeviceType = "24",
                DefaultCapabilities = "FF00FF",
                DefaultAdditionalCapabilities = "FF00FF00FF"
            };
        }

        public static Model.TerminalType XentissimoOrigin()
        {
            return new Model.TerminalType
            {
                Supplier = "SIX Payment Services (Supplier)",
                ReferenceSystem = "EP2",
                DeviceType = "22",
                DefaultCapabilities = "E0F0C0",
                DefaultAdditionalCapabilities = "C000B0A001",
                Range = "30'090'000 - 30'099'999"
            };
        }
    }
}
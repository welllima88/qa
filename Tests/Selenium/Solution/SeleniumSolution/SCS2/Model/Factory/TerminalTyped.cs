namespace Six.Scs.Test.Model.Factory
{
    public static class TerminalType

    {
        public static ValueObjects.TerminalType XentissimoMod()
        {
            return new ValueObjects.TerminalType
            {
                Supplier = "Alle Fremdhersteller",
                ReferenceSystem = "GICC",
                DeviceType = "24",
                DefaultCapabilities = "FF00FF",
                DefaultAdditionalCapabilities = "FF00FF00FF"
            };
        }

        public static ValueObjects.TerminalType XentissimoOrigin()
        {
            return new ValueObjects.TerminalType
            {
                Supplier = "SIX Payment Services (Supplier)",
                ReferenceSystem = "EP2",
                DeviceType = "22",
                DefaultCapabilities = "E0F0C0",
                DefaultAdditionalCapabilities = "C000B0A001",
                Range = "30'090'000 - 30'099'999",

            };
        }
    }
}
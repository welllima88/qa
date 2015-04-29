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
                DefaultAdditionalCapabilities = "FF00FF00FF",
                Providers = new[]
                {
                    "Accarda ep2",
                    "Aduno EP2"
                },
                Suppliers = new[]
                {
                    "CETREL S.A.",
                    "Coop ep2"
                }
            };
        }

        public static ValueObjects.TerminalType XentissimoOrigin()
        {
            return new ValueObjects.TerminalType
            {
                Supplier = "Alle Fremdhersteller",
                ReferenceSystem = "GICC",
                DeviceType = "24",
                DefaultCapabilities = "FF00FF",
                DefaultAdditionalCapabilities = "FF00FF00FF",
                Providers = new[]
                {
                    "CETREL S.A.",
                    "Coop ep2",
                    "Hypercom PayLife ACP Austria",
                    "Migros ep2",
                    "Paylife",
                    "PayLife DATALAN",
                    "PayLife Printec",
                    "PayLife Schweiz",
                    "PayLife Tend",
                    "SIX Payment Services AG",
                    "SIX Payment Services AT"
                },
                Suppliers = new[]
                {
                    "CETREL S.A.",
                    "Coop ep2",
                    "Hypercom PayLife ACP Austria",
                    "Migros ep2",
                    "Paylife",
                    "PayLife DATALAN",
                    "PayLife Printec",
                    "PayLife Schweiz",
                    "PayLife Tend",
                    "SIX Payment Services AG",
                    "SIX Payment Services AT"
                }
            };
        }
    }
}
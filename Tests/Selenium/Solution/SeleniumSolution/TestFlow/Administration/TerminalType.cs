namespace Six.Scs.Test.Administration
{
    public class TerminalType
    {
        public static Test.Model.ValueObjects.TerminalType Edit(
            Test.Model.ValueObjects.TerminalType terminalType)
        {
            return new Test.Model.ValueObjects.TerminalType();
        }

        public static Test.Model.ValueObjects.TerminalType View()
        {
            var actualTerminalType = new Test.Model.ValueObjects.TerminalType
            {
                DefaultAdditionalCapabilities =
                    Test.View.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                DefaultCapabilities = Test.View.Administration.TerminalType.View.DefaultCapabilities,
                DeviceType = Test.View.Administration.TerminalType.View.DeviceType,
                Range = Test.View.Administration.TerminalType.View.Range,
                ReferenceSystem = Test.View.Administration.TerminalType.View.ReferenceSystem,
                Supplier = Test.View.Administration.TerminalType.View.Supplier,
                Providers = Test.View.Administration.TerminalType.View.Providers,
                SoftwareIds = Test.View.Administration.TerminalType.View.SoftwareIds,
                Suppliers = Test.View.Administration.TerminalType.View.Suppliers
            };

            return actualTerminalType;
        }
    }
}
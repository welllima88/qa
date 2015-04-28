namespace Six.Scs.QA.Testlogic.Administration
{
    public class TerminalType
    {
        public static Selenium.Model.ValueObjects.TerminalType Edit(
            Selenium.Model.ValueObjects.TerminalType terminalType)
        {
            return new Selenium.Model.ValueObjects.TerminalType();
        }

        public static Selenium.Model.ValueObjects.TerminalType View()
        {
            var actualTerminalType = new Selenium.Model.ValueObjects.TerminalType
            {
                DefaultAdditionalCapabilities =
                    Selenium.View.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                DefaultCapabilities = Selenium.View.Administration.TerminalType.View.DefaultCapabilities,
                DeviceType = Selenium.View.Administration.TerminalType.View.DeviceType,
                Range = Selenium.View.Administration.TerminalType.View.Range,
                ReferenceSystem = Selenium.View.Administration.TerminalType.View.ReferenceSystem,
                Supplier = Selenium.View.Administration.TerminalType.View.Supplier,
                Providers = Selenium.View.Administration.TerminalType.View.Providers,
                SoftwareIds = Selenium.View.Administration.TerminalType.View.SoftwareIds,
                Suppliers = Selenium.View.Administration.TerminalType.View.Suppliers
            };

            return actualTerminalType;
        }
    }
}
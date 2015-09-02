using NUnit.Framework;

namespace Six.Scs.Test.Administration
{
    public class TerminalType
    {
        public static void Edit(Model.TerminalType terminalType)
        {
            Workflow.TerminalType.Edit(terminalType);
            Check(terminalType);
        }

        private static void Check(Model.TerminalType terminalType)
        {
            Assert.That(UI.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                Is.EqualTo(terminalType.DefaultAdditionalCapabilities));

            Assert.That(UI.Administration.TerminalType.View.DefaultCapabilities,
                Is.EqualTo(terminalType.DefaultCapabilities));
            Assert.That(UI.Administration.TerminalType.View.DeviceType, Is.EqualTo(terminalType.DeviceType));
            Assert.That(UI.Administration.TerminalType.View.Range, Is.EqualTo(terminalType.Range));
            Assert.That(UI.Administration.TerminalType.View.ReferenceSystem,
                Is.EqualTo(terminalType.ReferenceSystem));
            Assert.That(UI.Administration.TerminalType.View.Supplier, Is.EqualTo(terminalType.Supplier));
            Assert.That(UI.Administration.TerminalType.View.DeviceType, Is.EqualTo(terminalType.DeviceType));

            Assert.That(UI.Administration.TerminalType.View.SoftwareIds, Is.EqualTo(terminalType.SoftwareIds));
            Assert.That(UI.Administration.TerminalType.View.Providers, Is.EqualTo(terminalType.Providers));
            Assert.That(UI.Administration.TerminalType.View.Suppliers, Is.EqualTo(terminalType.Suppliers));
        }

        public static Model.TerminalType View()
        {
            return new Model.TerminalType
            {
                DefaultAdditionalCapabilities =
                    UI.Administration.TerminalType.View.DefaultAdditionalCapabilities,
                DefaultCapabilities = UI.Administration.TerminalType.View.DefaultCapabilities,
                DeviceType = UI.Administration.TerminalType.View.DeviceType,
                Range = UI.Administration.TerminalType.View.Range,
                ReferenceSystem = UI.Administration.TerminalType.View.ReferenceSystem,
                Supplier = UI.Administration.TerminalType.View.Supplier,
                Providers = UI.Administration.TerminalType.View.Providers,
                SoftwareIds = UI.Administration.TerminalType.View.SoftwareIds,
                Suppliers = UI.Administration.TerminalType.View.Suppliers
            };
        }
    }
}
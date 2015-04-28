using NUnit.Framework;
using Six.Scs.QA.Application.View.Administration.SerialNumberManage;
using Six.Scs.QA.Application.View.Common.Menu;

namespace Six.Scs.QA.Application.SmokeTest.SerialNumberImport
{
    [TestFixture]
    public class SerialNumberPreviewTest
    {
        [TestFixtureSetUp]
        public static void ClassInit()
        {
            LobbyMenu.SerialNumberManage.Click();
        }

        private void CheckPreview(string start, string length, string expectedPreview)
        {
            Import.StartField = start;
            Import.LengthField = length;

            Assert.AreEqual(expectedPreview, Import.Preview);
        }

        [Test]
        [Category("SerialNumberManagement"), Category("PreviewSerialNumbers")]
        public void PreviewSerialNumbers()
        {
            Import.SerialNumbersField =
                "1234567890A11223344556677889900000\n" +
                "11234567890B1122334455667788990000\n" +
                "111234567890C112233445566778899000\n" +
                "1111234567890D11223344556677889900\n";

            CheckPreview("1", "10", "1234567890");
            CheckPreview("2", "11", "234567890A1");
            CheckPreview("5", "1", "5");
            CheckPreview("5", "30", "567890A11223344556677889900000");
        }
    }
}
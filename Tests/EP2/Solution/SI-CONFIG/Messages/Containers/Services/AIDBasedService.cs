using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers.Services
{
    /// <summary>
    /// A Sevice controlled by an AID which is sent to the terminal
    /// </summary>
    public class AIDBasedService
    {
        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
        public byte[] AID { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
        public string AppLabel { get; set; }

        [Ep2DataElement(TagPrefix = CustomPrefixes.SixPrefix, MaxLength = 16)]
        public string Brand { get; set; }
    }
}
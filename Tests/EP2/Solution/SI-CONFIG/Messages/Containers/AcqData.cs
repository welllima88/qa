using SIX.EP2.Core.ContentHandling.Serialization;

namespace SIX.SCS.EP2.SIConfig.Host.Messages.Containers
{
	public class AcqData
	{
		[Ep2DataElement(TagName = "AcqID", TagPrefix = "ep2")]
		public string AcqID { get; set; }
	}
}
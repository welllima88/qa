using SIX.SCS.EP2.SIConfig.Host.Messages.Containers;
using SIX.SCS.EP2.SIConfig.Host.Messages.MsgOut;

namespace SIX.SCS.EP2.SIConfig.Host.Messages
{
	public interface IConfigNotificationVisitor
	{
		void Visit(ConfigDataNotificationV0200 ntf);
		void Visit(ConfigDataNotificationV0600 ntf);
		void Visit(ConfigDataNotificationV0500 ntf);
		void Visit(ConfigDataNotificationV0531 ntf);
		
		void Visit(TcdV0200 ntf);
		void Visit(TcdV0500 ntf);
		void Visit(TcdV0531 ntf);
		void Visit(TcdV0600 ntf);
		
	}
}
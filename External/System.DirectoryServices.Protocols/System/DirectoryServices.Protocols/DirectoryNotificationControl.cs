namespace System.DirectoryServices.Protocols
{
	public class DirectoryNotificationControl : DirectoryControl
	{
		public DirectoryNotificationControl() : base("1.2.840.113556.1.4.528", null, true, true)
		{
		}
	}
}
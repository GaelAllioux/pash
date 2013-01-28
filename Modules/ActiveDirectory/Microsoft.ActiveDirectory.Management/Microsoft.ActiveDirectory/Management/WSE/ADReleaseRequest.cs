using Microsoft.ActiveDirectory.Management;
using System;
using System.Xml;

namespace Microsoft.ActiveDirectory.Management.WSE
{
	internal class ADReleaseRequest : AdwsRequestMsg
	{
		private string _enumerationContext;

		public override string Action
		{
			get
			{
				return "http://schemas.xmlsoap.org/ws/2004/09/enumeration/Release";
			}
		}

		public ADReleaseRequest(string instance, string enumerationContext) : base(instance)
		{
			this._enumerationContext = enumerationContext;
		}

		protected override void OnWriteBodyContents(XmlDictionaryWriter writer)
		{
			writer.WriteStartElement("Release", "http://schemas.xmlsoap.org/ws/2004/09/enumeration");
			XmlUtility.SerializeEnumerationContext(writer, this._enumerationContext);
			writer.WriteEndElement();
		}

		protected override void OnWriteStartBody(XmlDictionaryWriter writer)
		{
			base.OnWriteStartBody(writer);
			writer.WriteXmlnsAttribute("wsen", "http://schemas.xmlsoap.org/ws/2004/09/enumeration");
		}
	}
}
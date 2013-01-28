namespace Microsoft.PowerShell.Cmdletization.Xml
{
    using System;
    using System.CodeDom.Compiler;
    using System.Xml;
    using System.Xml.Serialization;

    [GeneratedCode("sgen", "4.0")]
    internal sealed class PowerShellMetadataSerializer : XmlSerializer1
    {
        public override bool CanDeserialize(XmlReader xmlReader)
        {
            return xmlReader.IsStartElement("PowerShellMetadata", "http://schemas.microsoft.com/cmdlets-over-objects/2009/11");
        }

        protected override object Deserialize(XmlSerializationReader reader)
        {
            return ((XmlSerializationReader1) reader).Read49_PowerShellMetadata();
        }

        protected override void Serialize(object objectToSerialize, XmlSerializationWriter writer)
        {
            ((XmlSerializationWriter1) writer).Write49_PowerShellMetadata(objectToSerialize);
        }
    }
}


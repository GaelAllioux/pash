namespace System.Data.Services.Client
{
    using System;
    using System.Xml;

    internal sealed class Int64TypeConverter : PrimitiveTypeConverter
    {
        internal override object Parse(string text)
        {
            return XmlConvert.ToInt64(text);
        }

        internal override string ToString(object instance)
        {
            return XmlConvert.ToString((long) instance);
        }
    }
}


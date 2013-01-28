using System;

namespace System.DirectoryServices.ActiveDirectory
{
	[Flags]
	internal enum TRUST_ATTRIBUTE
	{
		TRUST_ATTRIBUTE_NON_TRANSITIVE = 1,
		TRUST_ATTRIBUTE_UPLEVEL_ONLY = 2,
		TRUST_ATTRIBUTE_QUARANTINED_DOMAIN = 4,
		TRUST_ATTRIBUTE_FOREST_TRANSITIVE = 8,
		TRUST_ATTRIBUTE_CROSS_ORGANIZATION = 16,
		TRUST_ATTRIBUTE_WITHIN_FOREST = 32,
		TRUST_ATTRIBUTE_TREAT_AS_EXTERNAL = 64
	}
}
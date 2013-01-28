using Microsoft.Data.Edm;
using Microsoft.Data.Edm.Library;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Data.Edm.Csdl
{
	internal static class CsdlConstants
	{
		internal const string CsdlFileExtension = ".csdl";

		internal const string Version1Namespace = "http://schemas.microsoft.com/ado/2006/04/edm";

		internal const string Version1Xsd = "Edm.Csdl.CSDLSchema_1.xsd";

		internal const string Version1_1Namespace = "http://schemas.microsoft.com/ado/2007/05/edm";

		internal const string Version1_1Xsd = "Edm.Csdl.CSDLSchema_1_1.xsd";

		internal const string Version1_2Namespace = "http://schemas.microsoft.com/ado/2008/01/edm";

		internal const string Version2Namespace = "http://schemas.microsoft.com/ado/2008/09/edm";

		internal const string Version2NamespaceAlternate = "http://schemas.microsoft.com/ado/2009/08/edm";

		internal const string Version2Xsd = "Edm.Csdl.CSDLSchema_2.xsd";

		internal const string Version3Namespace = "http://schemas.microsoft.com/ado/2009/11/edm";

		internal const string AnnotationNamespace = "http://schemas.microsoft.com/ado/2009/02/edm/annotation";

		internal const string AnnotationXsd = "Edm.Csdl.AnnotationSchema.xsd";

		internal const string CodeGenerationSchemaNamespace = "http://schemas.microsoft.com/ado/2006/04/codegeneration";

		internal const string CodeGenerationSchemaXsd = "Edm.Csdl.CodeGenerationSchema.xsd";

		internal const string AssociationAnnotationsAnnotation = "AssociationAnnotations";

		internal const string AssociationNameAnnotation = "AssociationName";

		internal const string AssociationNamespaceAnnotation = "AssociationNamespace";

		internal const string AssociationEndNameAnnotation = "AssociationEndName";

		internal const string AssociationSetAnnotationsAnnotation = "AssociationSetAnnotations";

		internal const string AssociationSetNameAnnotation = "AssociationSetName";

		internal const string SchemaNamespaceAnnotation = "SchemaNamespace";

		internal const string AnnotationSerializationLocationAnnotation = "AnnotationSerializationLocation";

		internal const string NamespacePrefixAnnotation = "NamespacePrefix";

		internal const string IsEnumMemberValueExplicitAnnotation = "IsEnumMemberValueExplicit";

		internal const string IsSerializedAsElementAnnotation = "IsSerializedAsElement";

		internal const string NamespaceAliasAnnotation = "NamespaceAlias";

		internal const string Attribute_Abstract = "Abstract";

		internal const string Attribute_Action = "Action";

		internal const string Attribute_Alias = "Alias";

		internal const string Attribute_Association = "Association";

		internal const string Attribute_BaseType = "BaseType";

		internal const string Attribute_Binary = "Binary";

		internal const string Attribute_Bool = "Bool";

		internal const string Attribute_Collation = "Collation";

		internal const string Attribute_ConcurrencyMode = "ConcurrencyMode";

		internal const string Attribute_ContainsTarget = "ContainsTarget";

		internal const string Attribute_DateTime = "DateTime";

		internal const string Attribute_DateTimeOffset = "DateTimeOffset";

		internal const string Attribute_Decimal = "Decimal";

		internal const string Attribute_DefaultValue = "DefaultValue";

		internal const string Attribute_FromRole = "FromRole";

		internal const string Attribute_ElementType = "ElementType";

		internal const string Attribute_Extends = "Extends";

		internal const string Attribute_EntityType = "EntityType";

		internal const string Attribute_EntitySet = "EntitySet";

		internal const string Attribute_EntitySetPath = "EntitySetPath";

		internal const string Attribute_FixedLength = "FixedLength";

		internal const string Attribute_Float = "Float";

		internal const string Attribute_Function = "Function";

		internal const string Attribute_Guid = "Guid";

		internal const string Attribute_Int = "Int";

		internal const string Attribute_IsBindable = "IsBindable";

		internal const string Attribute_IsComposable = "IsComposable";

		internal const string Attribute_IsFlags = "IsFlags";

		internal const string Attribute_IsSideEffecting = "IsSideEffecting";

		internal const string Attribute_MaxLength = "MaxLength";

		internal const string Attribute_MethodAccess = "MethodAccess";

		internal const string Attribute_Mode = "Mode";

		internal const string Attribute_Multiplicity = "Multiplicity";

		internal const string Attribute_Name = "Name";

		internal const string Attribute_Namespace = "Namespace";

		internal const string Attribute_Nullable = "Nullable";

		internal const string Attribute_OpenType = "OpenType";

		internal const string Attribute_Path = "Path";

		internal const string Attribute_Precision = "Precision";

		internal const string Attribute_Property = "Property";

		internal const string Attribute_Qualifier = "Qualifier";

		internal const string Attribute_Relationship = "Relationship";

		internal const string Attribute_ResultEnd = "ResultEnd";

		internal const string Attribute_ReturnType = "ReturnType";

		internal const string Attribute_Role = "Role";

		internal const string Attribute_Scale = "Scale";

		internal const string Attribute_Srid = "SRID";

		internal const string Attribute_String = "String";

		internal const string Attribute_Target = "Target";

		internal const string Attribute_Term = "Term";

		internal const string Attribute_Time = "Time";

		internal const string Attribute_ToRole = "ToRole";

		internal const string Attribute_Type = "Type";

		internal const string Attribute_UnderlyingType = "UnderlyingType";

		internal const string Attribute_Unicode = "Unicode";

		internal const string Attribute_Value = "Value";

		internal const string Element_Annotations = "Annotations";

		internal const string Element_Apply = "Apply";

		internal const string Element_AssertType = "AssertType";

		internal const string Element_Association = "Association";

		internal const string Element_AssociationSet = "AssociationSet";

		internal const string Element_Binary = "Binary";

		internal const string Element_Bool = "Bool";

		internal const string Element_Collection = "Collection";

		internal const string Element_CollectionType = "CollectionType";

		internal const string Element_ComplexType = "ComplexType";

		internal const string Element_DateTime = "DateTime";

		internal const string Element_DateTimeOffset = "DateTimeOffset";

		internal const string Element_Decimal = "Decimal";

		internal const string Element_DefiningExpression = "DefiningExpression";

		internal const string Element_Dependent = "Dependent";

		internal const string Element_Documentation = "Documentation";

		internal const string Element_End = "End";

		internal const string Element_EntityContainer = "EntityContainer";

		internal const string Element_EntitySet = "EntitySet";

		internal const string Element_EntitySetReference = "EntitySetReference";

		internal const string Element_EntityType = "EntityType";

		internal const string Element_EnumMemberReference = "EnumMemberReference";

		internal const string Element_EnumType = "EnumType";

		internal const string Element_Float = "Float";

		internal const string Element_Guid = "Guid";

		internal const string Element_Function = "Function";

		internal const string Element_FunctionImport = "FunctionImport";

		internal const string Element_FunctionReference = "FunctionReference";

		internal const string Element_If = "If";

		internal const string Element_IsType = "IsType";

		internal const string Element_Int = "Int";

		internal const string Element_Key = "Key";

		internal const string Element_LabeledElement = "LabeledElement";

		internal const string Element_LabeledElementReference = "LabeledElementReference";

		internal const string Element_LongDescription = "LongDescription";

		internal const string Element_Member = "Member";

		internal const string Element_NavigationProperty = "NavigationProperty";

		internal const string Element_Null = "Null";

		internal const string Element_OnDelete = "OnDelete";

		internal const string Element_Parameter = "Parameter";

		internal const string Element_ParameterReference = "ParameterReference";

		internal const string Element_Path = "Path";

		internal const string Element_Principal = "Principal";

		internal const string Element_Property = "Property";

		internal const string Element_PropertyRef = "PropertyRef";

		internal const string Element_PropertyReference = "PropertyReference";

		internal const string Element_PropertyValue = "PropertyValue";

		internal const string Element_Record = "Record";

		internal const string Element_ReferenceType = "ReferenceType";

		internal const string Element_ReferentialConstraint = "ReferentialConstraint";

		internal const string Element_ReturnType = "ReturnType";

		internal const string Element_RowType = "RowType";

		internal const string Element_Schema = "Schema";

		internal const string Element_String = "String";

		internal const string Element_Summary = "Summary";

		internal const string Element_Time = "Time";

		internal const string Element_TypeAnnotation = "TypeAnnotation";

		internal const string Element_TypeRef = "TypeRef";

		internal const string Element_Using = "Using";

		internal const string Element_ValueAnnotation = "ValueAnnotation";

		internal const string Element_ValueTerm = "ValueTerm";

		internal const string Property_ElementType = "ElementType";

		internal const string Property_TargetSet = "TargetSet";

		internal const string Property_SourceSet = "SourceSet";

		internal const string Value_Bag = "Bag";

		internal const string Value_Cascade = "Cascade";

		internal const string Value_Collection = "Collection";

		internal const string Value_Computed = "Computed";

		internal const string Value_EndMany = "*";

		internal const string Value_EndOptional = "0..1";

		internal const string Value_EndRequired = "1";

		internal const string Value_False = "false";

		internal const string Value_Fixed = "Fixed";

		internal const string Value_Identity = "Identity";

		internal const string Value_ModeIn = "In";

		internal const string Value_ModeOut = "Out";

		internal const string Value_ModeInOut = "InOut";

		internal const string Value_List = "List";

		internal const string Value_Max = "Max";

		internal const string Value_None = "None";

		internal const string Value_Ref = "Ref";

		internal const string Value_Self = "Self";

		internal const string Value_True = "true";

		internal const string Value_UnknownNamespace = "[UnknownNamespace]";

		internal const string Value_SridVariable = "Variable";

		internal const bool Default_Abstract = false;

		internal const bool Default_CollectionNullable = false;

		internal const EdmConcurrencyMode Default_ConcurrencyMode = EdmConcurrencyMode.None;

		internal const bool Default_ContainsTarget = false;

		internal const EdmFunctionParameterMode Default_FunctionParameterMode = EdmFunctionParameterMode.In;

		internal const bool Default_IsAtomic = false;

		internal const bool Default_IsBindable = false;

		internal const bool Default_IsComposable = false;

		internal const bool Default_IsFlags = false;

		internal const bool Default_IsSideEffecting = true;

		internal const bool Default_OpenType = false;

		internal const bool Default_Nullable = true;

		internal const int Default_SpatialGeographySrid = 0x10e6;

		internal const int Default_SpatialGeometrySrid = 0;

		internal const int Max_NameLength = 0x1e0;

		internal const int Max_NamespaceLength = 0x200;

		internal const string Version3Xsd = "Edm.Csdl.CSDLSchema_3.xsd";

		internal const string EdmxFileExtension = ".edmx";

		internal const string EdmxVersion1Namespace = "http://schemas.microsoft.com/ado/2007/06/edmx";

		internal const string EdmxVersion2Namespace = "http://schemas.microsoft.com/ado/2008/10/edmx";

		internal const string EdmxVersion3Namespace = "http://schemas.microsoft.com/ado/2009/11/edmx";

		internal const string ODataMetadataNamespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata";

		internal const string EdmxVersionAnnotation = "EdmxVersion";

		internal const string Prefix_Edmx = "edmx";

		internal const string Prefix_ODataMetadata = "m";

		internal const string Attribute_Version = "Version";

		internal const string Attribute_DataServiceVersion = "DataServiceVersion";

		internal const string Attribute_MaxDataServiceVersion = "MaxDataServiceVersion";

		internal const string Element_ConceptualModels = "ConceptualModels";

		internal const string Element_Edmx = "Edmx";

		internal const string Element_Runtime = "Runtime";

		internal const string Element_DataServices = "DataServices";

		public readonly static Version EdmxVersion1;

		public readonly static Version EdmxVersion2;

		public readonly static Version EdmxVersion3;

		public readonly static Version EdmxVersionLatest;

		internal static Dictionary<Version, string[]> SupportedVersions;

		internal static Dictionary<Version, string> SupportedEdmxVersions;

		internal static Dictionary<string, Version> SupportedEdmxNamespaces;

		internal static Dictionary<Version, Version> EdmToEdmxVersions;

		static CsdlConstants()
		{
			CsdlConstants.EdmxVersion1 = EdmConstants.EdmVersion1;
			CsdlConstants.EdmxVersion2 = EdmConstants.EdmVersion2;
			CsdlConstants.EdmxVersion3 = EdmConstants.EdmVersion3;
			CsdlConstants.EdmxVersionLatest = CsdlConstants.EdmxVersion3;
			Dictionary<Version, string[]> versions = new Dictionary<Version, string[]>();
			string[] strArrays = new string[1];
			strArrays[0] = "http://schemas.microsoft.com/ado/2006/04/edm";
			versions.Add(EdmConstants.EdmVersion1, strArrays);
			string[] strArrays1 = new string[1];
			strArrays1[0] = "http://schemas.microsoft.com/ado/2007/05/edm";
			versions.Add(EdmConstants.EdmVersion1_1, strArrays1);
			string[] strArrays2 = new string[1];
			strArrays2[0] = "http://schemas.microsoft.com/ado/2008/01/edm";
			versions.Add(EdmConstants.EdmVersion1_2, strArrays2);
			string[] strArrays3 = new string[2];
			strArrays3[0] = "http://schemas.microsoft.com/ado/2008/09/edm";
			strArrays3[1] = "http://schemas.microsoft.com/ado/2009/08/edm";
			versions.Add(EdmConstants.EdmVersion2, strArrays3);
			string[] strArrays4 = new string[1];
			strArrays4[0] = "http://schemas.microsoft.com/ado/2009/11/edm";
			versions.Add(EdmConstants.EdmVersion3, strArrays4);
			CsdlConstants.SupportedVersions = versions;
			Dictionary<Version, string> versions1 = new Dictionary<Version, string>();
			versions1.Add(CsdlConstants.EdmxVersion1, "http://schemas.microsoft.com/ado/2007/06/edmx");
			versions1.Add(CsdlConstants.EdmxVersion2, "http://schemas.microsoft.com/ado/2008/10/edmx");
			versions1.Add(CsdlConstants.EdmxVersion3, "http://schemas.microsoft.com/ado/2009/11/edmx");
			CsdlConstants.SupportedEdmxVersions = versions1;
			Dictionary<Version, string> supportedEdmxVersions = CsdlConstants.SupportedEdmxVersions;
			Func<KeyValuePair<Version, string>, string> func = (KeyValuePair<Version, string> v) => v.Value;
			CsdlConstants.SupportedEdmxNamespaces = supportedEdmxVersions.ToDictionary<KeyValuePair<Version, string>, string, Version>(func, (KeyValuePair<Version, string> v) => v.Key);
			Dictionary<Version, Version> versions2 = new Dictionary<Version, Version>();
			versions2.Add(EdmConstants.EdmVersion1, CsdlConstants.EdmxVersion1);
			versions2.Add(EdmConstants.EdmVersion1_1, CsdlConstants.EdmxVersion1);
			versions2.Add(EdmConstants.EdmVersion1_2, CsdlConstants.EdmxVersion1);
			versions2.Add(EdmConstants.EdmVersion2, CsdlConstants.EdmxVersion2);
			versions2.Add(EdmConstants.EdmVersion3, CsdlConstants.EdmxVersion3);
			CsdlConstants.EdmToEdmxVersions = versions2;
		}
	}
}
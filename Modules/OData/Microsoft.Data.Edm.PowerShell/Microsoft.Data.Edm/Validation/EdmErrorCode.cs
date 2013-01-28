namespace Microsoft.Data.Edm.Validation
{
	internal enum EdmErrorCode
	{
		InvalidErrorCodeValue = 0,
		StreamTypeReferencesNotSupportedBeforeV3 = 1,
		SpatialTypeReferencesNotSupportedBeforeV3 = 3,
		XmlError = 5,
		UnexpectedXmlNodeType = 8,
		UnexpectedXmlAttribute = 9,
		UnexpectedXmlElement = 10,
		TextNotAllowed = 11,
		EmptyFile = 12,
		MissingAttribute = 15,
		InvalidName = 17,
		MissingType = 18,
		AlreadyDefined = 19,
		InvalidVersionNumber = 25,
		InvalidBoolean = 27,
		BadProperty = 42,
		InvalidPropertyType = 44,
		PrecisionOutOfRange = 51,
		ScaleOutOfRange = 52,
		NameTooLong = 60,
		InvalidAssociation = 62,
		BadNavigationProperty = 74,
		InvalidKey = 75,
		InterfaceCriticalPropertyValueMustNotBeNull = 76,
		InterfaceCriticalKindValueMismatch = 77,
		InterfaceCriticalKindValueUnexpected = 78,
		InterfaceCriticalEnumerableMustNotHaveNullElements = 79,
		InterfaceCriticalEnumPropertyValueOutOfRange = 80,
		InterfaceCriticalNavigationPartnerInvalid = 81,
		InterfaceCriticalCycleInTypeHierarchy = 82,
		InvalidMultiplicity = 92,
		InvalidAction = 96,
		InvalidOnDelete = 97,
		BadUnresolvedComplexType = 98,
		InvalidEndEntitySet = 100,
		FunctionImportEntitySetExpressionIsInvalid = 103,
		EntitySetNavigationPropertyMappingMustPointToValidTargetForProperty = 109,
		InvalidRoleInRelationshipConstraint = 110,
		InvalidPropertyInRelationshipConstraint = 111,
		TypeMismatchRelationshipConstraint = 112,
		InvalidMultiplicityOfPrincipalEnd = 113,
		MismatchNumberOfPropertiesInRelationshipConstraint = 114,
		InvalidMultiplicityOfDependentEnd = 116,
		OpenTypeNotSupported = 117,
		VocabularyAnnotationsNotSupportedBeforeV3 = 118,
		SameRoleReferredInReferentialConstraint = 119,
		EntityKeyMustBeScalar = 128,
		EntityKeyMustNotBeBinary = 129,
		EndWithManyMultiplicityCannotHaveOperationsSpecified = 132,
		EntitySetTypeHasNoKeys = 133,
		InvalidConcurrencyMode = 144,
		ConcurrencyRedefinedOnSubtypeOfEntitySetType = 145,
		FunctionImportUnsupportedReturnType = 146,
		ComposableFunctionImportCannotBeSideEffecting = 147,
		FunctionImportReturnsEntitiesButDoesNotSpecifyEntitySet = 148,
		FunctionImportEntityTypeDoesNotMatchEntitySet = 149,
		FunctionImportSpecifiesEntitySetButDoesNotReturnEntityType = 150,
		ComposableFunctionImportMustHaveReturnType = 152,
		SimilarRelationshipEnd = 153,
		DuplicatePropertySpecifiedInEntityKey = 154,
		NullableComplexTypeProperty = 157,
		KeyMissingOnEntityType = 159,
		SystemNamespaceEncountered = 161,
		InvalidNamespaceName = 163,
		EnumMemberValueOutOfRange = 206,
		DuplicateEntityContainerMemberName = 218,
		InvalidAbstractComplexType = 220,
		InvalidPolymorphicComplexType = 221,
		NavigationPropertyEntityMustNotIndirectlyContainItself = 222,
		EntitySetRecursiveNavigationPropertyMappingsMustPointBackToSourceEntitySet = 223,
		BadAmbiguousElementBinding = 224,
		BadUnresolvedType = 225,
		BadUnresolvedPrimitiveType = 226,
		BadCyclicComplex = 227,
		BadCyclicEntityContainer = 228,
		BadCyclicEntity = 229,
		TypeSemanticsCouldNotConvertTypeReference = 230,
		ConstructibleEntitySetTypeInvalidFromEntityTypeRemoval = 231,
		BadUnresolvedEntityContainer = 232,
		BadUnresolvedEntitySet = 233,
		BadUnresolvedProperty = 234,
		BadNonComputableAssociationEnd = 235,
		NavigationPropertyTypeInvalidBecauseOfBadAssociation = 236,
		EntityMustHaveEntityBaseType = 237,
		ComplexTypeMustHaveComplexBaseType = 238,
		BadUnresolvedFunction = 239,
		RowTypeMustNotHaveBaseType = 240,
		AssociationSetEndRoleMustBelongToSetElementType = 241,
		KeyPropertyMustBelongToEntity = 242,
		ReferentialConstraintPrincipalEndMustBelongToAssociation = 243,
		DependentPropertiesMustBelongToDependentEntity = 244,
		DeclaringTypeMustBeCorrect = 245,
		FunctionsNotSupportedBeforeV2 = 256,
		ValueTermsNotSupportedBeforeV3 = 257,
		InvalidNavigationPropertyType = 258,
		UnderlyingTypeIsBadBecauseEnumTypeIsBad = 261,
		InvalidAssociationSetEndSetWrongType = 262,
		OnlyInputParametersAllowedInFunctions = 263,
		ComplexTypeMustHaveProperties = 264,
		FunctionImportParameterIncorrectType = 265,
		RowTypeMustHaveProperties = 266,
		DuplicateDependentProperty = 267,
		BindableFunctionImportMustHaveParameters = 268,
		FunctionImportSideEffectingNotSupportedBeforeV3 = 269,
		FunctionImportComposableNotSupportedBeforeV3 = 270,
		FunctionImportBindableNotSupportedBeforeV3 = 271,
		MaxLengthOutOfRange = 272,
		PathExpressionHasNoEntityContext = 274,
		InvalidSrid = 275,
		InvalidMaxLength = 276,
		InvalidLong = 277,
		InvalidInteger = 278,
		InvalidAssociationSet = 279,
		InvalidParameterMode = 280,
		BadUnresolvedEntityType = 281,
		InvalidValue = 282,
		InvalidBinary = 283,
		InvalidFloatingPoint = 284,
		InvalidDateTime = 285,
		InvalidDateTimeOffset = 286,
		InvalidDecimal = 287,
		InvalidGuid = 288,
		InvalidTypeKindNone = 289,
		InvalidIfExpressionIncorrectNumberOfOperands = 290,
		EnumsNotSupportedBeforeV3 = 291,
		EnumMemberTypeMustMatchEnumUnderlyingType = 292,
		InvalidIsTypeExpressionIncorrectNumberOfOperands = 293,
		InvalidTypeName = 294,
		InvalidQualifiedName = 295,
		NoReadersProvided = 296,
		NullXmlReader = 297,
		IsUnboundedCannotBeTrueWhileMaxLengthIsNotNull = 298,
		InvalidElementAnnotation = 299,
		InvalidLabeledElementExpressionIncorrectNumberOfOperands = 300,
		BadUnresolvedLabeledElement = 301,
		BadUnresolvedEnumMember = 302,
		InvalidAssertTypeExpressionIncorrectNumberOfOperands = 303,
		BadUnresolvedParameter = 304,
		NavigationPropertyWithRecursiveContainmentTargetMustBeOptional = 305,
		NavigationPropertyWithRecursiveContainmentSourceMustBeFromZeroOrOne = 306,
		NavigationPropertyWithNonRecursiveContainmentSourceMustBeFromOne = 307,
		NavigationPropertyContainsTargetNotSupportedBeforeV3 = 308,
		ImpossibleAnnotationsTarget = 309,
		CannotAssertNullableTypeAsNonNullableType = 310,
		CannotAssertPrimitiveExpressionAsNonPrimitiveType = 311,
		ExpressionPrimitiveKindNotValidForAssertedType = 312,
		NullCannotBeAssertedToBeANonNullableType = 313,
		ExpressionNotValidForTheAssertedType = 314,
		CollectionExpressionNotValidForNonCollectionType = 315,
		RecordExpressionNotValidForNonStructuredType = 316,
		RecordExpressionMissingRequiredProperty = 317,
		RecordExpressionHasExtraProperties = 318,
		DuplicateAnnotation = 319,
		IncorrectNumberOfArguments = 320,
		DuplicateAlias = 321,
		ReferencedTypeMustHaveValidName = 322,
		SingleFileExpected = 323,
		UnknownEdmxVersion = 324,
		UnknownEdmVersion = 325,
		NoSchemasProduced = 326,
		DuplicateEntityContainerName = 327,
		ContainerElementContainerNameIncorrect = 328,
		PrimitiveConstantExpressionNotValidForNonPrimitiveType = 329,
		IntegerConstantValueOutOfRange = 330,
		StringConstantLengthOutOfRange = 331,
		BinaryConstantLengthOutOfRange = 332,
		InvalidFunctionImportParameterMode = 333,
		TypeMustNotHaveKindOfNone = 334,
		PrimitiveTypeMustNotHaveKindOfNone = 335,
		PropertyMustNotHaveKindOfNone = 336,
		TermMustNotHaveKindOfNone = 337,
		SchemaElementMustNotHaveKindOfNone = 338,
		EntityContainerElementMustNotHaveKindOfNone = 339,
		BinaryValueCannotHaveEmptyValue = 340,
		EntitySetCanOnlyBeContainedByASingleNavigationProperty = 341,
		InconsistentNavigationPropertyPartner = 342,
		EntitySetCanOnlyHaveSingleNavigationPropertyWithContainment = 343,
		EntitySetNavigationMappingMustBeBidirectional = 344,
		DuplicateNavigationPropertyMapping = 345,
		AllNavigationPropertiesMustBeMapped = 346,
		TypeAnnotationMissingRequiredProperty = 347,
		TypeAnnotationHasExtraProperties = 348,
		InvalidTime = 349,
		InvalidPrimitiveValue = 350,
		EnumMustHaveIntegerUnderlyingType = 351,
		BadUnresolvedTerm = 352,
		BadPrincipalPropertiesInReferentialConstraint = 353,
		DuplicateDirectValueAnnotationFullName = 354,
		NoEntitySetsFoundForType = 355,
		CannotInferEntitySetWithMultipleSetsPerType = 356,
		InvalidEntitySetPath = 357,
		InvalidEnumMemberPath = 358,
		QualifierMustBeSimpleName = 359,
		BadUnresolvedEnumType = 360,
		BadUnresolvedTarget = 361
	}
}
namespace System.Management
{
	internal enum WMIQ_ASSOCQ_FLAGS
	{
		WMIQ_ASSOCQ_ASSOCIATORS = 1,
		WMIQ_ASSOCQ_REFERENCES = 2,
		WMIQ_ASSOCQ_RESULTCLASS = 4,
		WMIQ_ASSOCQ_ASSOCCLASS = 8,
		WMIQ_ASSOCQ_ROLE = 16,
		WMIQ_ASSOCQ_RESULTROLE = 32,
		WMIQ_ASSOCQ_REQUIREDQUALIFIER = 64,
		WMIQ_ASSOCQ_REQUIREDASSOCQUALIFIER = 128,
		WMIQ_ASSOCQ_CLASSDEFSONLY = 256,
		WMIQ_ASSOCQ_KEYSONLY = 512,
		WMIQ_ASSOCQ_SCHEMAONLY = 1024,
		WMIQ_ASSOCQ_CLASSREFSONLY = 2048
	}
}
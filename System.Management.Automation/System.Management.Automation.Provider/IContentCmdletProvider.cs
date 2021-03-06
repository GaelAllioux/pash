namespace System.Management.Automation.Provider
{
    using System;

    public interface IContentCmdletProvider
    {
        void ClearContent(string path);
        object ClearContentDynamicParameters(string path);
        IContentReader GetContentReader(string path);
        object GetContentReaderDynamicParameters(string path);
        IContentWriter GetContentWriter(string path);
        object GetContentWriterDynamicParameters(string path);
    }
}


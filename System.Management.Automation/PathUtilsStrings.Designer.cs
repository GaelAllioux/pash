﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Management.Automation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class PathUtilsStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PathUtilsStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.PathUtilsStrings", typeof(PathUtilsStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create the module {0} due to the following: {1}. Use a different argument for the -OutputModule parameter and retry..
        /// </summary>
        public static string ExportPSSession_CannotCreateOutputDirectory {
            get {
                return ResourceManager.GetString("ExportPSSession_CannotCreateOutputDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The directory &apos;{0}&apos; already exists.  Use the -Force parameter if you want to overwrite the directory and files within the directory..
        /// </summary>
        public static string ExportPSSession_ErrorDirectoryExists {
            get {
                return ResourceManager.GetString("ExportPSSession_ErrorDirectoryExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The module cannot be loaded because it has been generated with an incompatible version of {0} cmdlet. Generate the module with the {0} cmdlet from the current session and retry..
        /// </summary>
        public static string ExportPSSession_ScriptGeneratorVersionMismatch {
            get {
                return ResourceManager.GetString("ExportPSSession_ScriptGeneratorVersionMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform operation because the wildcard path {0} did not resolve to a file..
        /// </summary>
        public static string OutFile_DidNotResolveFile {
            get {
                return ResourceManager.GetString("OutFile_DidNotResolveFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot perform operation because the path resolved to more than one file. This command cannot operate on multiple files..
        /// </summary>
        public static string OutFile_MultipleFilesNotSupported {
            get {
                return ResourceManager.GetString("OutFile_MultipleFilesNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot open file because the current provider ({0}) cannot open a file..
        /// </summary>
        public static string OutFile_ReadWriteFileNotFileSystemProvider {
            get {
                return ResourceManager.GetString("OutFile_ReadWriteFileNotFileSystemProvider", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to unknown Encoding {0}; legal values are {1}..
        /// </summary>
        public static string OutFile_WriteToFileEncodingUnknown {
            get {
                return ResourceManager.GetString("OutFile_WriteToFileEncodingUnknown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} already exists and {1} was specified..
        /// </summary>
        public static string UtilityFileExistsNoClobber {
            get {
                return ResourceManager.GetString("UtilityFileExistsNoClobber", resourceCulture);
            }
        }
    }
}

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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Management.Automation.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Operation is not valid during the process of unloading the AppDomain.
        /// </summary>
        public static string AppDomainIsBeingUnloaded {
            get {
                return ResourceManager.GetString("AppDomainIsBeingUnloaded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CIM array cannot contain null elements..
        /// </summary>
        public static string ArrayCannotContainNullElements {
            get {
                return ResourceManager.GetString("ArrayCannotContainNullElements", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}:{1}.
        /// </summary>
        public static string CimClassToString {
            get {
                return ResourceManager.GetString("CimClassToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CimInstance doesn&apos;t have an associated namespace.
        /// </summary>
        public static string CimInstanceNamespaceIsNull {
            get {
                return ResourceManager.GetString("CimInstanceNamespaceIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {2} ({1}).
        /// </summary>
        public static string CimInstanceToStringFullData {
            get {
                return ResourceManager.GetString("CimInstanceToStringFullData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} ({1}).
        /// </summary>
        public static string CimInstanceToStringNoCaption {
            get {
                return ResourceManager.GetString("CimInstanceToStringNoCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        public static string CimInstanceToStringNoKeys {
            get {
                return ResourceManager.GetString("CimInstanceToStringNoKeys", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} = {1}.
        /// </summary>
        public static string CimNameAndValueToString {
            get {
                return ResourceManager.GetString("CimNameAndValueToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CimSession: {0}.
        /// </summary>
        public static string CimSessionToString {
            get {
                return ResourceManager.GetString("CimSessionToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Could not infer CimType from the provided .NET object..
        /// </summary>
        public static string DotNetValueToCimTypeConversionNotPossible {
            get {
                return ResourceManager.GetString("DotNetValueToCimTypeConversionNotPossible", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown error..
        /// </summary>
        public static string UnknownError {
            get {
                return ResourceManager.GetString("UnknownError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CimSessionOptions instance is invalid: unsupported protocol or unrecognized custom option.  Verify parameter passed to the CimSessionOptions(string) constructor and/or parameters passed to the CimSessionOptions.SetCustomOption(string, string) or CimSessionOptions.SetCustomOption(string, int) method..
        /// </summary>
        public static string UnrecognizedProtocolName {
            get {
                return ResourceManager.GetString("UnrecognizedProtocolName", resourceCulture);
            }
        }
    }
}

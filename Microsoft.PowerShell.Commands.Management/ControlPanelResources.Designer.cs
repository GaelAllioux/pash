﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell.Commands.Management {
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
    public class ControlPanelResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ControlPanelResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Commands.Management.ControlPanelResources", typeof(ControlPanelResources).Assembly);
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
        ///   Looks up a localized string similar to The {0} cmdlet is not supported on this version of Windows..
        /// </summary>
        public static string ControlPanelItemCmdletNotSupported {
            get {
                return ResourceManager.GetString("ControlPanelItemCmdletNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any Control Panel item with the given canonical name {0}..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenCanonicalName {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenCanonicalName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any control panel item with the given canonical name {0} that satisfies the specified category..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenCanonicalNameWithCategory {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenCanonicalNameWithCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any control panel item with the given category {0}..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenCategory {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find the Control Panel item based on the given instance of type {0}..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenInstance {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any control panel item with the given name {0}..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenName {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any Control Panel item with the given name {0} that satisfies the specified category..
        /// </summary>
        public static string NoControlPanelItemFoundForGivenNameWithCategory {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundForGivenNameWithCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any control panel item that has a canonical name..
        /// </summary>
        public static string NoControlPanelItemFoundWithNullCanonicalName {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundWithNullCanonicalName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find any Control Panel item that satisfies the specified category and has a canonical name..
        /// </summary>
        public static string NoControlPanelItemFoundWithNullCanonicalNameWithCategory {
            get {
                return ResourceManager.GetString("NoControlPanelItemFoundWithNullCanonicalNameWithCategory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Open.
        /// </summary>
        public static string VerbActionOpen {
            get {
                return ResourceManager.GetString("VerbActionOpen", resourceCulture);
            }
        }
    }
}

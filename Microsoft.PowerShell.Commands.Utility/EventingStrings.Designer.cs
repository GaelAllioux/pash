﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell.Commands.Utility {
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
    public class EventingStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EventingStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Commands.Utility.EventingStrings", typeof(EventingStrings).Assembly);
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
        ///   Looks up a localized string similar to Action must be specified for non-forwarded events..
        /// </summary>
        public static string ActionMandatoryForLocal {
            get {
                return ResourceManager.GetString("ActionMandatoryForLocal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event with identifier &apos;{0}&apos; does not exist..
        /// </summary>
        public static string EventIdentifierNotFound {
            get {
                return ResourceManager.GetString("EventIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event &apos;{0}&apos;.
        /// </summary>
        public static string EventResource {
            get {
                return ResourceManager.GetString("EventResource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event subscription &apos;{0}&apos;.
        /// </summary>
        public static string EventSubscription {
            get {
                return ResourceManager.GetString("EventSubscription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event subscription with identifier &apos;{0}&apos; does not exist..
        /// </summary>
        public static string EventSubscriptionNotFound {
            get {
                return ResourceManager.GetString("EventSubscriptionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event subscription with source identifier &apos;{0}&apos; does not exist..
        /// </summary>
        public static string EventSubscriptionSourceNotFound {
            get {
                return ResourceManager.GetString("EventSubscriptionSourceNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove.
        /// </summary>
        public static string Remove {
            get {
                return ResourceManager.GetString("Remove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event with source identifier &apos;{0}&apos; does not exist..
        /// </summary>
        public static string SourceIdentifierNotFound {
            get {
                return ResourceManager.GetString("SourceIdentifierNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unsubscribe.
        /// </summary>
        public static string Unsubscribe {
            get {
                return ResourceManager.GetString("Unsubscribe", resourceCulture);
            }
        }
    }
}

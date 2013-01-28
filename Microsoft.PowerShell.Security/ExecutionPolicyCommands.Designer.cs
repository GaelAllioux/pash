﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell.Security {
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
    public class ExecutionPolicyCommands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExecutionPolicyCommands() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.Security.ExecutionPolicyCommands", typeof(ExecutionPolicyCommands).Assembly);
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
        ///   Looks up a localized string similar to Cannot set execution policy. Execution policies at the MachinePolicy or UserPolicy scopes must be set through Group Policy..
        /// </summary>
        public static string CantSetGroupPolicy {
            get {
                return ResourceManager.GetString("CantSetGroupPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Windows PowerShell updated your execution policy successfully, but the setting is overridden by a policy defined at a more specific scope.  Due to the override, your shell will retain its current effective execution policy of {0}. Type &quot;Get-ExecutionPolicy -List&quot; to view your execution policy settings. For more information please see &quot;Get-Help Set-ExecutionPolicy&quot;..
        /// </summary>
        public static string ExecutionPolicyOverridden {
            get {
                return ResourceManager.GetString("ExecutionPolicyOverridden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Contact your system administrator..
        /// </summary>
        public static string ExecutionPolicyOverriddenRecommendedAction {
            get {
                return ResourceManager.GetString("ExecutionPolicyOverriddenRecommendedAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot get execution policy. Specify only the List or Scope parameters..
        /// </summary>
        public static string ListAndScopeSpecified {
            get {
                return ResourceManager.GetString("ListAndScopeSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execution Policy Change.
        /// </summary>
        public static string SetExecutionPolicyCaption {
            get {
                return ResourceManager.GetString("SetExecutionPolicyCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The execution policy helps protect you from scripts that you do not trust. Changing the execution policy might expose you to the security risks described in the about_Execution_Policies help topic at http://go.microsoft.com/fwlink/?LinkID=135170. Do you want to change the execution policy?.
        /// </summary>
        public static string SetExecutionPolicyQuery {
            get {
                return ResourceManager.GetString("SetExecutionPolicyQuery", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.PowerShell {
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
    internal class ConsoleHostStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ConsoleHostStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.PowerShell.ConsoleHostStrings", typeof(ConsoleHostStrings).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred while running &apos;{0}&apos;: {1}.
        /// </summary>
        internal static string CommandFailed {
            get {
                return ResourceManager.GetString("CommandFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; was not run as the session in which it was intended to run was either closed or broken.
        /// </summary>
        internal static string CommandNotExecuted {
            get {
                return ResourceManager.GetString("CommandNotExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance of the ConsoleHost class has already been created for this process..
        /// </summary>
        internal static string ConsoleHostIsSingleton {
            get {
                return ResourceManager.GetString("ConsoleHostIsSingleton", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}:{1,-3} {2}.
        /// </summary>
        internal static string DebuggerSourceCodeFormat {
            get {
                return ResourceManager.GetString("DebuggerSourceCodeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PS&gt;.
        /// </summary>
        internal static string DefaultPrompt {
            get {
                return ResourceManager.GetString("DefaultPrompt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Entering debug mode. Use h or ? for help. .
        /// </summary>
        internal static string EnteringDebugger {
            get {
                return ResourceManager.GetString("EnteringDebugger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ctrl-Break typed; exiting..
        /// </summary>
        internal static string ExitOnCtrlBreakMessage {
            get {
                return ResourceManager.GetString("ExitOnCtrlBreakMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hit {0}.
        /// </summary>
        internal static string HitBreakpoint {
            get {
                return ResourceManager.GetString("HitBreakpoint", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The console host is not currently transcribing..
        /// </summary>
        internal static string HostNotTranscribing {
            get {
                return ResourceManager.GetString("HostNotTranscribing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command &apos;{0}&apos; could not be run because some Windows PowerShell Snap-Ins did not load..
        /// </summary>
        internal static string InitialCommandNotExecuted {
            get {
                return ResourceManager.GetString("InitialCommandNotExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Execution of initialization script has failed. The shell cannot be started..
        /// </summary>
        internal static string InitScriptFailed {
            get {
                return ResourceManager.GetString("InitScriptFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot process input loop. ExitCurrentLoop was called when no InputLoops were running..
        /// </summary>
        internal static string InputExitCurrentLoopOutOfSyncError {
            get {
                return ResourceManager.GetString("InputExitCurrentLoopOutOfSyncError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A nested prompt cannot be entered until the host is running at least one prompt loop..
        /// </summary>
        internal static string NestedPromptEntryError {
            get {
                return ResourceManager.GetString("NestedPromptEntryError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///The current session does not support debugging; execution will continue.
        ///
        ///.
        /// </summary>
        internal static string SessionDoesNotSupportDebugger {
            get {
                return ResourceManager.GetString("SessionDoesNotSupportDebugger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The shell cannot be started. A failure occurred during initialization:.
        /// </summary>
        internal static string ShellCannotBeStarted {
            get {
                return ResourceManager.GetString("ShellCannotBeStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot display prompt because too many nested prompts are already running..
        /// </summary>
        internal static string TooManyNestedPromptsError {
            get {
                return ResourceManager.GetString("TooManyNestedPromptsError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to **********************
        ///Windows PowerShell transcript end
        ///End time: {0:yyyyMMddHHmmss}
        ///**********************.
        /// </summary>
        internal static string TranscriptEpilogue {
            get {
                return ResourceManager.GetString("TranscriptEpilogue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to **********************
        ///Windows PowerShell transcript start
        ///Start time: {0:yyyyMMddHHmmss}
        ///Username  : {1}\{2} 
        ///Machine	  : {3} ({4}) 
        ///**********************.
        /// </summary>
        internal static string TranscriptPrologue {
            get {
                return ResourceManager.GetString("TranscriptPrologue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error has occurred that was not properly handled. Additional information is shown below. The Windows PowerShell process will exit..
        /// </summary>
        internal static string UnhandledExceptionShutdownMessage {
            get {
                return ResourceManager.GetString("UnhandledExceptionShutdownMessage", resourceCulture);
            }
        }
    }
}

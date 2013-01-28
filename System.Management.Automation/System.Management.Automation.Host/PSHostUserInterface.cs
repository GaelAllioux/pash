namespace System.Management.Automation.Host
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Management.Automation;
    using System.Security;

    public abstract class PSHostUserInterface
    {
        protected PSHostUserInterface()
        {
        }

        public abstract Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions);
        public abstract int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice);
        public abstract PSCredential PromptForCredential(string caption, string message, string userName, string targetName);
        public abstract PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options);
        public abstract string ReadLine();
        public abstract SecureString ReadLineAsSecureString();
        public abstract void Write(string value);
        public abstract void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value);
        public abstract void WriteDebugLine(string message);
        public abstract void WriteErrorLine(string value);
        public virtual void WriteLine()
        {
            this.WriteLine("");
        }

        public abstract void WriteLine(string value);
        public virtual void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
        {
            if ((value != null) && (value.Length != 0))
            {
                this.Write(foregroundColor, backgroundColor, value);
            }
            this.Write("\n");
        }

        public abstract void WriteProgress(long sourceId, ProgressRecord record);
        public abstract void WriteVerboseLine(string message);
        public abstract void WriteWarningLine(string message);

        public abstract PSHostRawUserInterface RawUI { get; }
    }
}


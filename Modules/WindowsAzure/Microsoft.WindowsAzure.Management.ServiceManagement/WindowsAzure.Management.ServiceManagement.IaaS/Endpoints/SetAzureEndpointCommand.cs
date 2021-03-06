using Microsoft.Samples.WindowsAzure.ServiceManagement;
using Microsoft.WindowsAzure.Management.ServiceManagement.IaaS;
using Microsoft.WindowsAzure.Management.ServiceManagement.Model;
using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Management.ServiceManagement.IaaS.Endpoints
{
	[Cmdlet("Set", "AzureEndpoint", DefaultParameterSetName="NoLB")]
	public class SetAzureEndpointCommand : VirtualMachineConfigurationCmdletBase
	{
		[Parameter(Mandatory=true, ParameterSetName="LoadBalanced", HelpMessage="Load Balanced Endpoint Set Name")]
		public string LBSetName
		{
			get;
			set;
		}

		[Parameter(Position=2, Mandatory=true, ParameterSetName="LoadBalanced", HelpMessage="Local port.")]
		[Parameter(Position=2, Mandatory=true, ParameterSetName="NoLB", HelpMessage="Local port.")]
		[ValidateNotNullOrEmpty]
		public int LocalPort
		{
			get;
			set;
		}

		[Parameter(Position=0, ParameterSetName="LoadBalanced", Mandatory=true, HelpMessage="Endpoint name")]
		[Parameter(Position=0, ParameterSetName="NoLB", Mandatory=true, HelpMessage="Endpoint name")]
		[ValidateNotNullOrEmpty]
		public string Name
		{
			get;
			set;
		}

		[Parameter(Mandatory=false, ParameterSetName="LoadBalanced", HelpMessage="Probe Relative Path")]
		public string ProbePath
		{
			get;
			set;
		}

		[Parameter(Mandatory=true, ParameterSetName="LoadBalanced", HelpMessage="Probe Port")]
		public int ProbePort
		{
			get;
			set;
		}

		[Parameter(Mandatory=true, ParameterSetName="LoadBalanced", HelpMessage="Probe Protocol (http/tcp)")]
		[ValidateSet(new string[] { "tcp", "http" }, IgnoreCase=true)]
		public string ProbeProtocol
		{
			get;
			set;
		}

		[Parameter(Position=1, Mandatory=true, ParameterSetName="LoadBalanced", HelpMessage="Endpoint protocol.")]
		[Parameter(Position=1, Mandatory=true, ParameterSetName="NoLB", HelpMessage="Endpoint protocol.")]
		[ValidateNotNullOrEmpty]
		[ValidateSet(new string[] { "tcp", "udp" }, IgnoreCase=true)]
		public string Protocol
		{
			get;
			set;
		}

		[Parameter(Mandatory=false, ParameterSetName="LoadBalanced", HelpMessage="Public port.")]
		[Parameter(Mandatory=false, ParameterSetName="NoLB", HelpMessage="Public port.")]
		[ValidateNotNullOrEmpty]
		public int? PublicPort
		{
			get;
			set;
		}

		public SetAzureEndpointCommand()
		{
		}

		protected Collection<InputEndpoint> GetInputEndpoints()
		{
			PersistentVM instance = base.VM.GetInstance();
			NetworkConfigurationSet networkConfigurationSet = instance.ConfigurationSets.OfType<NetworkConfigurationSet>().SingleOrDefault<NetworkConfigurationSet>();
			if (networkConfigurationSet == null)
			{
				networkConfigurationSet = new NetworkConfigurationSet();
				instance.ConfigurationSets.Add(networkConfigurationSet);
			}
			if (networkConfigurationSet.InputEndpoints == null)
			{
				networkConfigurationSet.InputEndpoints = new Collection<InputEndpoint>();
			}
			Collection<InputEndpoint> inputEndpoints = networkConfigurationSet.InputEndpoints;
			return inputEndpoints;
		}

		protected override void ProcessRecord()
		{
			int? publicPort;
			Func<InputEndpoint, bool> func = null;
			try
			{
				base.ProcessRecord();
				this.ValidateParameters();
				Collection<InputEndpoint> inputEndpoints = this.GetInputEndpoints();
				Collection<InputEndpoint> inputEndpoints1 = inputEndpoints;
				if (func == null)
				{
					func = (InputEndpoint p) => p.Name == this.Name;
				}
				InputEndpoint localPort = inputEndpoints1.Where<InputEndpoint>(func).SingleOrDefault<InputEndpoint>();
				if (localPort == null)
				{
					object[] name = new object[1];
					name[0] = this.Name;
					base.ThrowTerminatingError(new ErrorRecord(new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "An endpoint named '{0}' cannot be found in the configuration of this VM. Use New-ExternalEndpoint to define it.", name)), string.Empty, ErrorCategory.InvalidData, null));
				}
				InputEndpoint inputEndpoint = localPort;
				int? nullable = this.PublicPort;
				if (nullable.HasValue)
				{
					publicPort = this.PublicPort;
				}
				else
				{
					int? nullable1 = null;
					publicPort = nullable1;
				}
				inputEndpoint.Port = publicPort;
				localPort.LocalPort = this.LocalPort;
				localPort.Protocol = this.Protocol;
				if (!string.IsNullOrEmpty(this.LBSetName))
				{
					localPort.LoadBalancedEndpointSetName = this.LBSetName;
					localPort.LoadBalancerProbe = new LoadBalancerProbe();
					localPort.LoadBalancerProbe.Protocol = this.ProbeProtocol;
					if (localPort.LoadBalancerProbe.Protocol == "http")
					{
						if (string.IsNullOrEmpty(this.ProbePath))
						{
							localPort.LoadBalancerProbe.Path = "/";
						}
						else
						{
							localPort.LoadBalancerProbe.Path = this.ProbePath;
						}
					}
					localPort.LoadBalancerProbe.Port = this.ProbePort;
				}
				base.WriteObject(base.VM, true);
			}
			catch (Exception exception1)
			{
				Exception exception = exception1;
				base.WriteError(new ErrorRecord(exception, string.Empty, ErrorCategory.CloseError, null));
			}
		}

		private void ValidateParameters()
		{
			bool hasValue;
			bool flag;
			if (string.Compare(base.ParameterSetName, "LoadBalanced", StringComparison.OrdinalIgnoreCase) == 0)
			{
				if (string.Compare(this.ProbeProtocol, "tcp", StringComparison.OrdinalIgnoreCase) != 0 || string.IsNullOrEmpty(this.ProbePath))
				{
					if (string.Compare(this.ProbeProtocol, "http", StringComparison.OrdinalIgnoreCase) == 0 && string.IsNullOrEmpty(this.ProbePath))
					{
						throw new ArgumentException("ProbePath is required for http");
					}
				}
				else
				{
					throw new ArgumentException("ProbePath not valid with tcp");
				}
			}
			if (this.LocalPort < 0 || this.LocalPort > 0xffff)
			{
				throw new ArgumentException("Ports must be in the range of 0 - 65535");
			}
			else
			{
				int? publicPort = this.PublicPort;
				if (publicPort.HasValue)
				{
					int? nullable = this.PublicPort;
					if (nullable.GetValueOrDefault() >= 0)
					{
						hasValue = false;
					}
					else
					{
						hasValue = nullable.HasValue;
					}
					if (!hasValue)
					{
						int? publicPort1 = this.PublicPort;
						if (publicPort1.GetValueOrDefault() <= 0xffff)
						{
							flag = false;
						}
						else
						{
							flag = publicPort1.HasValue;
						}
						if (!flag)
						{
							goto Label0;
						}
					}
					throw new ArgumentException("Ports must be in the range of 0 - 65535");
				}
			Label0:
				if (this.ProbePort < 0 || this.ProbePort > 0xffff)
				{
					throw new ArgumentException("Ports must be in the range of 0 - 65535");
				}
				else
				{
					return;
				}
			}
		}
	}
}
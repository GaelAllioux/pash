using System;

namespace TaskScheduler.Implementation
{
	public class OSXTaskScheduler : TaskScheduler
	{
		public OSXTaskScheduler ()
		{
		}

		#region ITaskService implementation

		public ITaskFolder GetFolder (string Path)
		{
			throw new NotImplementedException ();
		}

		public void _VtblGap1_1 ()
		{

		}

		public ITaskDefinition NewTask (uint flags)
		{
			throw new NotImplementedException ();
		}

		public void Connect (object serverName, object user, object domain, object password)
		{

		}

		#endregion
	}
}


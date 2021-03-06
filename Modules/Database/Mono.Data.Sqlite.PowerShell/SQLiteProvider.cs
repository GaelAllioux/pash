/*
	Copyright (c) 2012 Code Owls LLC

	Permission is hereby granted, free of charge, to any person obtaining a copy 
	of this software and associated documentation files (the "Software"), to 
	deal in the Software without restriction, including without limitation the 
	rights to use, copy, modify, merge, publish, distribute, sublicense, and/or 
	sell copies of the Software, and to permit persons to whom the Software is 
	furnished to do so, subject to the following conditions:

	The above copyright notice and this permission notice shall be included in 
	all copies or substantial portions of the Software.

	THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
	IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
	FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
	AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
	LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
	FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
	IN THE SOFTWARE. 
*/
using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Provider;
using System.Text;
using System.Threading;
using System.Transactions;
using Mono.Data.PowerShell.Provider;
using Mono.Data.PowerShell.Paths.Processors;

namespace Mono.Data.Sqlite.PowerShell
{
    [CmdletProvider("SQLite", ProviderCapabilities.ShouldProcess | ProviderCapabilities.Filter | ProviderCapabilities.Transactions )]
    public class SQLiteProvider : ProviderWithTransactions
    {
        public class DriveParams
        {
            public DriveParams()
            {
                PersistentConnection = new SwitchParameter(true);
            }

            internal string ConnectionString { get; set; }

            [Parameter()]
            public SwitchParameter PersistentConnection { get; set; }
        }

        class Session : IDisposable
        {
            private SQLiteProvider _sqLiteProvider;
            private SQLiteConnectionWrapper _wrapper;
            private static int Index = 0;
            private readonly int _index;
            public Session(SQLiteProvider sqLiteProvider)
            {
                _index = ++Index;
                _sqLiteProvider = sqLiteProvider;
                
                _sqLiteProvider.WriteDebug( String.Format( "+{0} Opening session {0}", _index) );
            }
            
            public SqliteConnection Connection
            {
                get
                {
                    if( null == _wrapper )
                    {
                        _wrapper = _sqLiteProvider.Drive.CreateConnectionWrapper();

                        if (null != Transaction.Current)
                        {
                            _wrapper.Connection.EnlistTransaction(Transaction.Current);
                        }   
                    }
                    return _wrapper.Connection;                                            
                }
            }

            public void Dispose()
            {
                if( null != _wrapper )
                {
                    _wrapper.Dispose();
                    _wrapper = null;
                }
                if (null != _sqLiteProvider)
                {
                    _sqLiteProvider.WriteDebug(String.Format("-{0} Closing session {0}", _index));
                    _sqLiteProvider = null;
                }
            }
        }

        private SQLiteDrive Drive
        {
            get 
            { 
                var drive = PSDriveInfo as SQLiteDrive;
                if( null != drive )
                {
                    return drive;
                }

                return this.ProviderInfo.Drives.Where(d => d is SQLiteDrive).Cast<SQLiteDrive>().FirstOrDefault();
            }
        }

        protected override object NewDriveDynamicParameters()
        {
            return new DriveParams();
        }

        protected override PSDriveInfo NewDrive(PSDriveInfo drive)
        {            
            if( drive is SQLiteDrive )
            {
                return drive;
            }

			var cs = drive.Root;
            if( String.IsNullOrEmpty( cs ) || ! cs.StartsWith("[") )
            {
                if (String.IsNullOrEmpty(cs))
                {
                    var builder = new SqliteConnectionStringBuilder();
                    builder.DataSource = ":memory:";
                    cs = builder.ToString();
                }
            
                drive = new PSDriveInfo(
                    drive.Name,
                    drive.Provider,
                    "/",
                    drive.Description,
                    drive.Credential);
            }

			return new SQLiteDrive( drive, String.Format( "[{0}]", cs), DynamicParameters as DriveParams );
        }

        protected override PSDriveInfo RemoveDrive(PSDriveInfo drive)
        {
            SQLiteDrive sqLiteDrive = ProviderInfo.Drives.Where(d => d.Name == drive.Name) as SQLiteDrive;
            if( null != sqLiteDrive )
            {
                sqLiteDrive.DisposeDrive();
            }

            return drive;
        }

        protected override IPathNodeProcessor PathNodeProcessor
        {
            get
            {
                if( null == _currentSession )
                {
					NewSession ();
                    //throw new InvalidOperationException( "no current SQLite session exists" );
                }

                return new SQLitePathNodeProcessor(
                    new SQLiteContext
                        {
                            Connection = _currentSession.Connection,
                            Provider = this
                        });
            }
        }

        private Session _currentSession;    
        public override IDisposable NewSession()
        {
            _currentSession = new Session( this );
            return _currentSession;
        }

		protected override bool ItemExists (string path)
		{
			return base.ItemExists(path);
		}

    }
}

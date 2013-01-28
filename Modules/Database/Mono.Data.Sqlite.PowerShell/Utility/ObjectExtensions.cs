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
using System.Collections;
using System.Linq;
using System.Management.Automation;

namespace Mono.Data.Sqlite.PowerShell
{
    public static class ObjectExtensions
    {
        public static PSObject ToPSObject( this object o )
        {
            if( null == o )
            {
                return null;
            }

            if( o is PSObject )
            {
                return o as PSObject;
            }

            var pso = PSObject.AsPSObject(o);
           
            if( pso.BaseObject is Hashtable )
            {
                var h = pso.BaseObject as Hashtable;
                pso = new PSObject();

                ( from string key in h.Keys
                  select new PSNoteProperty( key, h[key] ) )
                  .ToList().ForEach( pso.Properties.Add );
                
            }

            return pso;
        }
    }
}

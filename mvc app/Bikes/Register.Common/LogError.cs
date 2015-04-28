using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common
{
    public class LogError : ILogError
    {
        public void LogIt(string s)
        {
            System.Diagnostics.Debug.WriteLine("ERROR: {0}", s);
        }
    }
}

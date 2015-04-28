using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common
{
    public class LogWarning : ILogWarning
    {
        public void LogIt(string s)
        {
            System.Diagnostics.Debug.WriteLine("WARNING: {0}", s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common.Interfaces
{
    public interface ILoggerFactory
    {
        TLogger CreateLogger<TLogger>() where TLogger : ILogger;
    }
} 

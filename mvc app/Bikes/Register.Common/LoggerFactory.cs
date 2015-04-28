using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common
{
    public class LoggerFactory : ILoggerFactory
    {
        public TLogger CreateLogger<TLogger>() where TLogger : ILogger
        {
            if (typeof(TLogger) == typeof(ILogError))
            {
                return (TLogger)(object)new LogError();
            }

            if (typeof(TLogger) == typeof(ILogWarning))
            {
                return (TLogger)(object)new LogWarning();    
            }

            return default(TLogger);
        }
    }
}

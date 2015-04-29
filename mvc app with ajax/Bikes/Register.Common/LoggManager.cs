using Register.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Common
{
    public static class LoggManager
    {
        private static ILoggerFactory loggerFactory;

        public static TLogger CreateLogger<TLogger>() where TLogger : ILogger
        {
            TLogger result = loggerFactory.CreateLogger<TLogger>();
            return result;
        }

        public static void RegisterLogger(ILoggerFactory factory) 
        {
            loggerFactory = factory;
        }
    }
}

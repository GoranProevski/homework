using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Logger : ILoggerInterface
    {
        private static Logger log = null;

        public void CarState(string s)
        {
            Console.WriteLine("car {0}", s);
            Console.ReadLine();
            
        }

        public void CarException(string s)
        {
            Console.WriteLine("car {0}", s);
            Console.ReadLine();
        }

        private Logger()
        {

        }

        public static Logger Logg 
        {
            get 
            {
                if (log == null)
                {
                    log = new Logger();
                    return log;
                }
                return log;
            }
        }

        public static ILoggerInterface GetLogger()
        {
            return Logg;
        }
    }
}

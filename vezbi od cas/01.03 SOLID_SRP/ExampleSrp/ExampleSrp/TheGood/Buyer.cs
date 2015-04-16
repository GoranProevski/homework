using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class Buyer
    {
        ILoggerInterface logger;

        public void SetLoggers(ILoggerInterface log)
        {
            logger = log;
        }

        public ILoggerInterface Log()
        {
            return this.logger;
        }
    }
}

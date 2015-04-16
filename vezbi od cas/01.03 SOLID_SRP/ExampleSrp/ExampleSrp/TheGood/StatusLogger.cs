using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSrp.TheGood
{
    public class StatusLogger
    {

        //public string statusMessage { get; set; }
        public void CarChangedState(string s)
        {

            Console.WriteLine("==============Car changed state:{0}", s);
        }
    
    }
}

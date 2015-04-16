using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.TheGood
{
    public class HardCover : Book
    {
        public override double GetPrice(double price)
        {
            return base.GetPrice(price) + 100;
        } 
    }
}

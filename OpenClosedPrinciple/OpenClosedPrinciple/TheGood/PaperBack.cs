using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.TheGood
{
    public class PaperBack : Book
    {
        public override double GetPrice(double price)
        {
            return base.GetPrice(price) - 50;
        }
    }
}

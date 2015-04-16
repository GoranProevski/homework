using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.TheGood
{
    public class Book
    {
        public virtual double GetPrice(double price) 
        {
            return price;
        }
    }
}

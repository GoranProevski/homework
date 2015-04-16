using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple.TheBad
{
    public class Book
    {
        public string bookType { get; private set; }

        public double GetPrice(double price)
        {
            if (bookType == "Paperback")
            {
                return price - 50;
            }
            else
            {
                return price;
            }
        }
    }
}

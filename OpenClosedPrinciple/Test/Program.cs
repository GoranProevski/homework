using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.TheGood;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 100;
            Book simple = new Book();
            Console.WriteLine(simple.GetPrice(price));
            PaperBack cheaper = new PaperBack();
            Console.WriteLine(cheaper.GetPrice(price));
            HardCover expencive = new HardCover();
            Console.WriteLine(expencive.GetPrice(price));
            Console.ReadLine();

        }
    }
}

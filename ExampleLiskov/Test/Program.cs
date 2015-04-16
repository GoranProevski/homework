using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ExampleLiskov.TheBad;
using ExampleLiskov.TheGood;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Bird> birdsList = new List<Bird>();

            //birdsList.Add(new Bird());
            //birdsList.Add(new Crow());
            //birdsList.Add(new Penguin());

            List<FlyingBird> birdsList = new List<FlyingBird>();
            birdsList.Add(new Crow());
            birdsList.Add(new Albatros());
            //birdsList.Add(new Penguin());

            FlyaAll(birdsList);
        }

        private static void FlyaAll(List<FlyingBird> birdsList)
        {
            foreach (var b in birdsList)
            {
                b.Fly();
                Console.WriteLine("type: {0}", b.GetType().ToString());
            }
            Console.ReadLine();
        }


    }
}

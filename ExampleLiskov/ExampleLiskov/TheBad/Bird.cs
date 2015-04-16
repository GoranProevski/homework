using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLiskov.TheBad
{
    public class Bird
    {
        public virtual void Fly() { }
        public virtual void Eat() { }
    }
}

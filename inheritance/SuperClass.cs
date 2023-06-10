using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class SuperClass
    {
        public void DoSomething()
        {
            Console.WriteLine("Something done");
        } 
        public void DoSomethingElse()
        {
            Console.WriteLine("Something else done");
        }
        public virtual void DoSomethingSpecial() // virtual enables overide
        {
            Console.WriteLine("I am dancing");
        }
    }
}

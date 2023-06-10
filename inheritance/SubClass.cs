using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class SubClass: SuperClass
    {
        public void DoSomethingUnique()
        {
            Console.WriteLine("Something unique done");
        }

        public override void DoSomethingSpecial()
        {
            Console.WriteLine("I am running");
        }
    }
}

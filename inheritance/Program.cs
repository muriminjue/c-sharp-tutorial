using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperClass superClass = new SuperClass();
            superClass.DoSomething();
            superClass.DoSomethingSpecial();

            SubClass subClass = new SubClass();
            subClass.DoSomething();
            subClass.DoSomethingUnique();
            subClass.DoSomethingSpecial();


            Console.ReadLine();
        }
    }
}

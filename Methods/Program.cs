using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("mike", 21);
            SayHi("John", 29);
            SayHi("Duke", 31);

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine(name + " is " + age + " years old");
        }
    }
}

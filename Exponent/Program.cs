using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Raise to power: ");
            int power = Convert.ToInt32(Console.ReadLine());

            double result = 1;
            for(int i = 0; i < power; i++)
            {
                result *= num;

            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}

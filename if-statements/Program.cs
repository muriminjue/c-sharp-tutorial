using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement checks which number is greater
            Console.Write("Enter First Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }else if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            } else
            {
                Console.WriteLine($"{num2} is greater than {num1}");

            }

            Console.ReadLine();
        }
    }
}

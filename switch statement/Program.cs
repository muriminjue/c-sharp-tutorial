using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // statment to return name of day from number
            Console.Write("Enter Day number: ");
            double DayNum = Convert.ToDouble(Console.ReadLine());

            switch (DayNum)
            {
                case 0:
                    Console.WriteLine("Today is Monday");
                    break;
                case 1:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 2:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case 3:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 4:
                    Console.WriteLine("Today is Friday");
                    break;
                case 5:
                    Console.WriteLine("Today is Saturday");
                    break;
                case 6:
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Not a valid day number");
                    break;
            }
            Console.ReadLine();
        }
    }
}

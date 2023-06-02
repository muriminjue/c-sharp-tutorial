using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // c# arrays should be the same type
            int[] luckyNumber = { 4, 6, 7, 8, 9, 12, 25, 39 };
            string[] friends = new string[5]; // must have length of array

            Console.WriteLine(luckyNumber[2]);

            luckyNumber[2] = 45;
            Console.WriteLine(luckyNumber[2]);

            Console.ReadLine();
        }
    }
}

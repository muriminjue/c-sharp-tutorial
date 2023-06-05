using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGroup =
             {
                {1,2 },
                {2,4 },
                {5,6 }
            };

            int[,] numberGroup1 = new int[3 /*Rows */, 4 /*Columns */];

            Console.WriteLine(numberGroup[1,0]);
            Console.WriteLine(numberGroup[1,1]);
            Console.WriteLine(numberGroup[2,1]);

            Console.ReadLine();
        }
    }
}

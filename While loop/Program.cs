using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // assuming we have a number of items to print say n items. The print task will be run until the items done
            int index = 5;
            while (index > 0)
            {
                Console.WriteLine($"Job no {index} is being run");
                index--;
                
            }

            // repeat with a do while loop
            int index1 = 5;
            do
            {
                Console.WriteLine($"Job no {index1} is being run");
                index1--;
                // important diference is this code will run atleast once even if the condition is false
            } while (index1 > 0);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num / num1);
                               
            }           
            catch(Exception error)
            {
                Console.Write(error.Message);
            }
            finally
            {
                Console.WriteLine("End of program");
            }

            Console.ReadLine();

         
        }
    }
}

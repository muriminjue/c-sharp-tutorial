using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int CorrectNum = 3, attempts = 3;
            
            while (attempts > 0)
            {
                Console.Write("Guess the number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                if (num == CorrectNum)
                {
                    Console.WriteLine("Yaay, You got it");
                    break; 
                } 
                
                attempts--;
            }
        if (attempts == 0){
                Console.WriteLine("You lose");
            }
            Console.ReadLine();
        }
    }
}

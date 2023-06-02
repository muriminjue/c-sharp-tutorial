using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_app
{
    class Program
    {
        static void Main(string[] args)
        {
            // introduction
            string CharaterName = "John Lennox";
            int CharacterAge = 70;
            Console.WriteLine("My name is " + CharaterName);
            Console.WriteLine($"I am {CharacterAge} years old" );
            Console.ReadLine();

            // Data types
            string phrase = "Some long sentence";
            char grade = 'A'; // single character
            int age = 30; // postive and negative intengers
            float amount = 3.3F; // 
            double gpa = 3.3; // 
            decimal weight = 3.344332534M; // 
            bool IsMale = true; // true or false


            // strings in C#
            Console.WriteLine("My\nname"); // next line
            Console.WriteLine("My\"name\""); // Add quotes

            string Phrase = "My Name";

            Console.WriteLine(Phrase.Length); // number of Characters n string
            Console.WriteLine(Phrase.ToUpper()); // Convert to upper case
            Console.WriteLine(Phrase.ToLower()); // Convert to lower case
            Console.WriteLine(Phrase.Contains("Na")); // Check if contains Character / substring
            Console.WriteLine(Phrase[0]); // get letter at index
            Console.WriteLine(Phrase.IndexOf("N")); // get postion of substring or Character
            Console.WriteLine(Phrase.Substring(4)); // get characters from posisiton
            Console.WriteLine(Phrase.Substring(4, 2)); // get characters from postion to lenth of 2

            Console.ReadLine();


            // numbers in C#
            int num = 6;
            num++; //increament to 7
            num--; //decreament back to 6

            Console.WriteLine(5 % 2); // modulus
            Console.WriteLine(Math.Round(4.8));
            Console.ReadLine();

            // console readline app
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");
            Console.ReadLine();

        }
    }
}
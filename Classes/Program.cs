using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            book1.title = "Jake and Jill";
            book1.author = "Fred Long";
            book1.pages = 95;

            Console.WriteLine(book1.author);

            Console.ReadLine();
        }
    }
}

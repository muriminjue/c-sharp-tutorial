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

            Student student1 = new Student("Mathew Murimi", "English Lit", 22, 2);
            Student student2 = new Student("Mike North", "Art", 12, 4);

            Console.WriteLine(student1.name);
            Console.WriteLine(student1.Year);
            Console.WriteLine(student1.Minor());
            Console.WriteLine(student2.Minor());


            Console.ReadLine();
        }
    }
}

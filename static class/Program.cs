using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicTools basicTools = new BasicTools(); // class is not static
            BasicTools.DoSomething(); // static class method
                                      
           // AdvancedTools advancedTools = new AdvancedTools(); // impossible because  class is static
            AdvancedTools.DoSomething(); // static class method

            Console.ReadLine();
        }
    }
}

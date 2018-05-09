using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = '\'';
            Console.WriteLine(ch);
            Console.WriteLine();

            string str = @"""Hello""";
            Console.WriteLine(str);
            Console.WriteLine();

            string str1 = "\"Hello\nWorld\"";
            Console.WriteLine(str1);
            Console.WriteLine();

            string str2 = "Hello\\World";
            Console.WriteLine(str2);
            Console.WriteLine();

            string str3 = "Hello\0World\0";
            Console.WriteLine(str3);
            Console.WriteLine();

            string str4 = "Alert Sound:\a";
            Console.WriteLine(str4);
            Console.WriteLine();

            string str5 = "Back\bspace";
            Console.WriteLine(str5);
            Console.WriteLine();

            string str6 = "Tab\tTab";
            Console.WriteLine(str6);
            Console.WriteLine();
        }
    }
}

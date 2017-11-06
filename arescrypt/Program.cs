using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arescrypt
{
    class Program
    {
        static string sessionUsername = System.Environment.UserName;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, " + sessionUsername);

            Console.Write("\nPress any key to continue . . . ");
            Console.ReadKey(); // Hang the console
        }
    }
}

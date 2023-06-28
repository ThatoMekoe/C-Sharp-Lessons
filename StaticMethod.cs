using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Greetings("James");
            Console.ReadKey();
        }

        public static void Greetings(string Name)
        {
            Console.WriteLine("Welcome {0}, this is an example of a static method.", Name);
        }
    }
}

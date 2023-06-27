using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Console Banking.");
            Console.WriteLine("Enter your name to log in.");
            Console.WriteLine();
            string cName = Console.ReadLine();
            Console.WriteLine();
            
            switch (cName)
            {
                case "James":
                case "Bond":
                case "Vin":
                case "Diesel":
                    Console.WriteLine("Glad you could join us today, {0}.", cName);
                    break;
                default: Console.WriteLine("Your name does not exist in the system.");
                    break;
            }
            Console.ReadKey();
        }
    }
}

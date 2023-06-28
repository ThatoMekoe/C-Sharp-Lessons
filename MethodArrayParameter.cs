using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodArrayParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamsNumberMethod(2,4,6,8,10,12);
            Console.WriteLine();

            string[] Names = new string[2];
            Names[0] = "Steve";
            Names[1] = "Warren";
            ParamsStringMethod(Names);
            Console.ReadKey();
        }

        public static void ParamsNumberMethod(params int[] Number)
        {
            Console.WriteLine("Items in array:");
            foreach (int n in Number)
            {
                Console.WriteLine(n);
            }
        }

        public static void ParamsStringMethod(params string[] Names)
        {
            Console.WriteLine("List of names:");
            foreach (string n in Names)
            {
                Console.WriteLine(n);
            }
        }
    }
}

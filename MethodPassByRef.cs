using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            FirstMethod(ref num);
            Console.WriteLine(num);
            Console.ReadKey();
        }

        public static void FirstMethod(ref int Number)
        {
            Number = 333;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            int Sub = 0;
            Calculator(20, 15, out Sum, out Sub);

            Console.WriteLine("Addition: {0}, Subtraction: {1}.", Sum, Sub);
            Console.ReadKey();
        }

        public static void Calculator(int fNum, int sNum, out int Addition, out int Subtraction)
        {
            Addition = fNum + sNum;
            Subtraction = fNum - sNum;
        }
    }
}

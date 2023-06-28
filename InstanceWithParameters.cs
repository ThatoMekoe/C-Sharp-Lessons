using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceWithParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string date = DateTime.Now.ToLongDateString();

            p.instMessage("This is an example of an instance method with parameters.");
            p.anotherMethod(date);

            Console.ReadKey();
        }

        public void instMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        public void anotherMethod(string Today)
        {
            Console.WriteLine("Today is {0}", Today);
        }
    }
}

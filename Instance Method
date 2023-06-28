using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.instMessage();
            p.anotherMethod();

            Console.ReadKey();
        }

        public void instMessage()
        {
            Console.WriteLine("This is an example of an instance method.");
        }

        public void anotherMethod()
        {
            string date = DateTime.Now.ToLongDateString();
            Console.WriteLine("Today is {0}", date);
        }
    }
}

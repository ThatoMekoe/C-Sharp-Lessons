using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to order from our shop?");
            Begin:
            Console.WriteLine("1-Milk (R20), 2-Sugar (R15), 3-Oil (R25), 4-Bread (R18).");
            Console.WriteLine();
            int total = 0;
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1: total += 20;
                    break;
                case 2:
                    total += 15;
                    break;
                case 3:
                    total += 25;
                    break;
                case 4:
                    total += 18;
                    break;
                default: Console.WriteLine("The choice '{0}' is invalid. Please try again.", option);
                    goto Begin;
            }

            Decide:
            Console.WriteLine("Would you like to make another order? Yes or No");
            Console.WriteLine();
            string order = Console.ReadLine();
            Console.WriteLine();

            switch (order.ToLower())
            {
                case "yes": goto Begin;
                case "no": break;
                default: Console.WriteLine("You made an invalid choice. Please try again.");
                    goto Decide;
            }
                
            Console.WriteLine("Your bill is: R{0}", total);
            Console.ReadKey();
        }
    }
}

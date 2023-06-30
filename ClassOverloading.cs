using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee("James", "Bond", "PTA", "abc@yahoo");
            E1.PrintEmployee();
            Console.ReadKey();
        }

        class Employee
        {
            static string _Name;
            static string _Surname;
            static string _Address;
            static string _Email;

            public Employee(string Name, string Surname, string Address, string Email)
            {
                _Name = Name;
                _Surname = Surname;
                _Address = Address;
                _Email = Email;
            }

            public Employee() : this("Name is not provided.", "Surname is not provided.", "Address is not provided.", "Email is not provided.")
            {
            }

            public void PrintEmployee()
            {
                Console.WriteLine("Full Name: {0}.", _Name + " " + _Surname);
                Console.WriteLine("Address: {0}.", _Address);
                Console.WriteLine("Email: {0}.", _Email);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee
            {
                ID = 1234
            };


            Employee employee2 = new Employee
            {
                ID = 1234
            };
            


            if (employee1 == employee2)
            {
                Console.Write("These two employees have the same ID number.");
            }
            else
            {
                Console.Write("These are two different employees.");
            }
            Console.ReadLine();

        }
    }
}

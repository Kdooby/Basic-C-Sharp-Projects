using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>() { "Kevin", "Makenna", "Bear", "Bob" };

            Employee<int> employeeNum = new Employee<int>();
            employeeNum.things = new List<int>() { 4, 3, 0, 5 };

            employee.listOfThings();
            employeeNum.listOfThings();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_2
{
    class Program
    {
        static void Main(string[] args)
        {

            mathClass method1 = new mathClass();



            Console.WriteLine("This method takes in an integer and adds 25: {0} ",  method1.same_method(10));
            Console.ReadLine();

            Console.WriteLine("This method takes in a decimal and returns an int: {0} ", method1.same_method(3.25m));
            Console.ReadLine();

            Console.WriteLine("This method takes in a string and returns an int, and then multiplies by 5: {0} ", method1.same_method("10"));
            Console.ReadLine();
        }


    }
}

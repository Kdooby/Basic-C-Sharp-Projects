using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("If you would like, enter a second number: ");
            string y = Console.ReadLine();
            bool optional = string.IsNullOrEmpty(y); //if second number is null or empty

            if (optional == true)
            {
                // if no input on second number, run this code
                mathClass n = new mathClass();
                int i = n.Optional(input);
                Console.WriteLine("You have a total of: {0}", i);
            }

            else 
            {
                // if user inputs a second number, run this code which utilizes the first number as well. 
                mathClass n = new mathClass();
                int i = n.Optional(input, Convert.ToInt32(y)); // turns string into int
                Console.WriteLine("You have a total of: {0}", i);
            }

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_5
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass n = new mathClass();

            Console.WriteLine("Enter a Number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            n.DivideBy(input1, out int quotient);
            Console.ReadLine();

            // Overloaded Class

            mathClass d = new mathClass();
            Console.WriteLine("Enter a Decimal: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            d.DivideBy(input2, quotient: out int total);
            Console.ReadLine();


        }
       
        
    }
}   
    

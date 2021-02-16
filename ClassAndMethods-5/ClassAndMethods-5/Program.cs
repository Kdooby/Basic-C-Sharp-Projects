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

            Console.WriteLine("Enter a Decimal: ");
            decimal input2 = Convert.ToDecimal(Console.ReadLine());

            n.DivideBy((int)input2, quotient: out decimal total);
            Console.ReadLine();


            Class2.Method();
            Console.ReadLine();
        }


       
        
    }
}   
    

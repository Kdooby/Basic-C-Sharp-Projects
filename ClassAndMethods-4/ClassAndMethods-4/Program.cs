using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass n = new mathClass();
            
            Console.WriteLine("Enter a number here: ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter another number here: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            
            n.method(input1, input2);
            Console.ReadLine();


            Console.WriteLine("Using Parameter Names: ");
            Console.ReadLine();

            n.method(num1: input1, num2: input2);
            Console.ReadLine();



        }    
    }
}

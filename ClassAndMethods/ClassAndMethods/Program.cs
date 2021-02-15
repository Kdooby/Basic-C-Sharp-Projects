using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see some basic math: ");
            int input = Convert.ToInt32(Console.ReadLine());

            simpleMath answer = new simpleMath();
            int x = answer.addition(input, 25);
            int y = answer.division(input, 4);
            int z = answer.modulus(input, 2);
            
            Console.WriteLine(input + " plus 25 equals: " + x);
            Console.ReadLine();
            
            Console.WriteLine(input + " divided by 4 equals: " + y);
            Console.ReadLine();
            
            Console.WriteLine(input + " divided by 2, has the remainder of " + z);
            Console.ReadLine();
            

        }
    }
}

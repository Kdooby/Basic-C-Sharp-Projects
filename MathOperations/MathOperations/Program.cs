using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a number to multiply by 50: ");
            double num1 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(num1 * 50);
            Console.ReadLine();
            Console.WriteLine(); //Line Break


            Console.WriteLine("Input a number to add 25 to: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num2 + 25);
            Console.ReadLine();
            Console.WriteLine(); //Line Break

            Console.WriteLine("Input a number to divide 12.5 by: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num3 / 12.5);
            Console.ReadLine();
            Console.WriteLine(); //Line Break

            Console.WriteLine("Input a number to see if it is greater than 50: ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrfalse = num4 > 50;
            Console.WriteLine(trueOrfalse.ToString());
            Console.ReadLine();
            Console.WriteLine(); //Line Break

            Console.WriteLine("Input a number to see the remainder when divided by 7: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num5 % 7);
            Console.ReadLine();
            Console.WriteLine(); //Line Break

        }
    }
}


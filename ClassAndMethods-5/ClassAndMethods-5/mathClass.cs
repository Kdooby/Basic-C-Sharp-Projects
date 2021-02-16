using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndMethods_5
{
    public class mathClass
    {
        public void DivideBy(int x, out int quotient)
        {
            quotient = x / 2;
            Console.WriteLine("The answer is: " + quotient);


        }

        public void DivideBy(decimal x, out decimal quotient)
        {
            quotient = x / 2;
            Console.WriteLine("The answer is: " + quotient);
        }

    }


    static class Class2
    {
        public static void Method()
        {
            Console.WriteLine("Testing...Testing...");
        }
    }


}

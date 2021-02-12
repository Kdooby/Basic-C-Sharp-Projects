using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Package Express.  Please follow the instructions below");
            Console.ReadLine();

            Console.WriteLine("Enter Package Weight: ");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight <= 50)
            {
                Console.WriteLine();
            }

            else
            {
                Console.WriteLine("Package is to heavy to be shipped with Package Express. Goodbye");
                Console.ReadLine();
                Environment.Exit(0);
            }
            

            Console.WriteLine("Enter Package Width: ");
            decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Package Height: ");
            decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Package Length: ");
            decimal packageLength = Convert.ToDecimal(Console.ReadLine());

            decimal dimensions = packageWidth + packageHeight + packageLength;


            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Goodbye");
                Console.ReadLine();
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("Shipping Quote: ");
                decimal quote = dimensions * packageWeight / 100;
                Console.WriteLine(quote);
        
            }

            Console.ReadLine();
            

        }
    }
}

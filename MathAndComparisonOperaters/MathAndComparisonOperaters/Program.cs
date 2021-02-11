using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperaters
{
    class Program
    {
        static void Main()
        {
            
            // Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("What is person1's Hourly Rate?");
            double userInput = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours does Person1 work per week?");
            double userInput2 = Convert.ToDouble(Console.ReadLine());

            // Person 2
            Console.WriteLine("Person 2: ");
            Console.WriteLine("What is person's 2 hourly Rate");
            double userInput3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How many hours does person2 work per week?");
            double userInput4 = Convert.ToDouble(Console.ReadLine());

            // Comparison 

            Console.WriteLine("The annual salary of Person 1 is:");
            double income1 = userInput * userInput2 * 52;
            Console.WriteLine(income1);
            Console.WriteLine("The annual salary of Person 2 is:");
            double income2 = userInput3 * userInput4 * 52;
            Console.WriteLine(income2);

            // Boolean check
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            double person1 = income1;
            double person2 = income2;
            bool value = person1 > person2;
            Console.WriteLine(value);
            Console.ReadLine();


        }
    }
}

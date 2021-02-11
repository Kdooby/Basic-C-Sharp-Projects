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
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            // Person 1

            Console.WriteLine("Person 1");
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hourly Rate: ");
            string howMuch1 = Console.ReadLine();
            double hourly1 = Convert.ToDouble(howMuch1);
            Console.WriteLine(hourly1);
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hours Per Week: ");
            string howMany1 = Console.ReadLine();
            double hoursWeek1 = Convert.ToDouble(howMany1);
            Console.WriteLine(hoursWeek1);
            Console.ReadLine();

            // Person 2

            Console.WriteLine("Person 2");
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hourly Rate: ");
            string howMuch2 = Console.ReadLine();
            double hourly2 = Convert.ToDouble(howMuch2);
            Console.WriteLine(hourly2);
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hours Per Week: ");
            string howMany2 = Console.ReadLine();
            double hoursWeek2 = Convert.ToDouble(howMany2);
            Console.ReadLine();

            // Annual Salary

            Console.WriteLine("Annual Salary of Person 1: ");
            double weeklySalary1 = hourly1 * hoursWeek1;
            double annualSalary1 = weeklySalary1 * 52;
            Console.WriteLine(annualSalary1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2: ");
            double weeklySalary2 = hourly2 * hoursWeek2;
            double annualSalary2 = weeklySalary2 * 52;
            Console.WriteLine(annualSalary2);
            Console.ReadLine();

            // Comparison

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1Morep2 = annualSalary1 > annualSalary2;
            Console.WriteLine(p1Morep2);
            Console.ReadLine();


        }
    }
}

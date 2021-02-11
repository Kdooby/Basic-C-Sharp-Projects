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
            double hourly1 = 16.15;
            Console.WriteLine(hourly1);
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hours Per Week: ");
            double hoursWeek1 = 37.8;
            Console.WriteLine(hoursWeek1);
            Console.WriteLine(); //Line Break
            Console.ReadLine();

            // Person 2

            Console.WriteLine("Person 2");
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hourly Rate: ");
            double hourly2 = 15.67;
            Console.WriteLine(hourly2);
            Console.WriteLine(); //Line Break
            Console.WriteLine("Hours Per Week: ");
            double hoursWeek2 = 39.0;
            Console.WriteLine(hoursWeek2);
            Console.WriteLine(); //Line Break
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

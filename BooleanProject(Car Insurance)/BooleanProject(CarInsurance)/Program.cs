using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age? ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); //Line Break

            Console.WriteLine("Have you ever had a DUI? (true/false) ");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(); //Line Break

            Console.WriteLine("How many speeding tickets do you have? ");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); //Line Break

            Console.WriteLine("Qualified?");
            bool applicant = userAge > 15 && dui == false && tickets <= 3;
            Console.WriteLine(applicant);
            Console.ReadLine();


        }
    }
}


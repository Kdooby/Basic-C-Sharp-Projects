using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age?: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input <= 0)
                {
                    throw new ArgumentException();
                }
                DateTime today = DateTime.Now;
                int year = today.Year;
                int yearBorn = year - input;
                Console.WriteLine("You were born on {0}", yearBorn);
                Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You're how old!? How can you even use the computer? ");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An everyday normal error has occured.\n" +
                    "Definitely something you did, not me.\n" +
                    "Your computer's hard drive will be wiped in 10 seconds.\n" +
                    "GoodBye.");
                Console.ReadLine();
            }
        }
    }
}

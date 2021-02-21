using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Console.WriteLine("Type in the current day of the week: ");
                string today = Console.ReadLine(); 
                DaysOfWeek input = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), today);
                
                {
                    Console.WriteLine("It is {0} today!", input);
                }

                
            } 
            catch (FormatException)
            {
               
                Console.WriteLine("Please enter an actual day of the week...");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week...");
            }
            Console.ReadLine();
        }

        
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        
    }
}

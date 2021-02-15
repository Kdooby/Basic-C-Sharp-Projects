using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 6, 12, 24, 64, 30, 16 };
            Console.WriteLine("Input a number to divide by each number in the list: ");

            try
            {
                
                int input = Convert.ToInt32(Console.ReadLine());
                
                foreach (int num in numbers)
                {

                    int solution = num / input;
                    Console.WriteLine(num + " divided by " + input + " equals: " + solution);
                    
                }
             
            }
            
            catch ( DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by 0.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a Whole Number");
                
            }

            Console.WriteLine(); // Line Break
            Console.WriteLine("The program has emerged from the \"try/catch\" block and continued with the program execution. ");
            Console.ReadLine();

        }   

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number here: ");
            int input = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter file = new StreamWriter(@"C:\Users\kevin\Desktop\Logs\log.txt")) //true will append to file otherwise will create new file which overwrites the previous input
            {
                file.WriteLine(input);
                
            }

            string text = File.ReadAllText(@"C:\Users\kevin\Desktop\Logs\log.txt");
            Console.WriteLine("\nThis is the number you inputed: {0} ", text);
            
            Console.ReadLine();


            //DATETIME

            Console.Write("Today's Date and Time is " + DateTime.Now);
            Console.Write("\nPlease enter another number here: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan duration = new TimeSpan(input2, 0, 0);  //input2 = hours, 0 = minutes, 0 = seconds
            DateTime answer = now.Add(duration);
            Console.WriteLine(input2 + " hours from now it will be " + answer);
            Console.ReadLine();

            
        }
    }
}

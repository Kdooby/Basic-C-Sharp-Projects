using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            
            Console.WriteLine("Student Daily Report");
            Console.ReadLine(); //line break

            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(); //line break

            Console.Write("What course are you on?: ");
            string course = Console.ReadLine();
            Console.WriteLine(course);
            Console.WriteLine(); //line break

            Console.Write("What page number?: ");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pageNum);
            Console.WriteLine(); //line break

            Console.Write("Do you need help with anytihng? Please answer \"true\" or \"false\": ");
            string true_false = Console.ReadLine();
            Console.WriteLine(true_false);
            Console.WriteLine();//line break

            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string help = Console.ReadLine();
            Console.WriteLine(help);
            Console.WriteLine();//line break

            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string experiences = Console.ReadLine();
            Console.WriteLine(experiences);
            Console.WriteLine();//line break

            Console.Write("How many hours did you study today?: ");
            short hours = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(hours);
            Console.WriteLine();//line break

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();//line break


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "This is ";
            string two = "a string ";
            string three = "concatenation. ";

            Console.WriteLine(one + two + three);
            Console.WriteLine(); //Line Break

            string upper = "this is uppercase";
            upper = upper.ToUpper();
            Console.WriteLine(upper);
            Console.WriteLine(); //Line Break


            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hello darkness my old friend, ");
            sb.AppendLine("I've come to talk with you again.");
            sb.AppendLine("Because a vision softly creeping, ");
            sb.AppendLine("Left its seeds while I was sleeping.");
            sb.AppendLine("And the vision that was planted in my brain, ");
            sb.AppendLine("Still remains, ");
            sb.AppendLine("Within the Sound of Silence.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

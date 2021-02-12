using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparisonLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // While Statement

            Console.WriteLine("Guess the missing word in this sentence: ");
            Console.WriteLine("The quick brown fox __ over the lazy dog. ");
            string guess = Console.ReadLine();
            bool word = guess == "jumps";
            
            while (!word) // "!" equivalent to "is false"
            {
                switch(guess)
                {
                    case "jumps":
                        Console.WriteLine("Congratulations!  You have guessed the missing word!");
                        Console.WriteLine("The quick brown fox JUMPS over the lazy dog. ");
                        word = true; // guessed correctly, switches boolean to true
                        break;

                    default:
                        Console.WriteLine("Please guess again");
                        Console.WriteLine("The quick brown fox __ over the lazy dog. ");
                        guess = Console.ReadLine();
                        break;

                }
                Console.ReadLine();
                
            }

            Console.WriteLine(); // Line Break
            // Do While Statement

            Console.WriteLine("Who is your favorite Superhero?: ");
            string answer = Console.ReadLine();
            bool rightAnswer = answer == "Spider-Man";

            do
            {
                switch (answer)
                {
                    case "Spider-Man":
                        Console.WriteLine("Me Too!! Did we just become best friends!?");
                        rightAnswer = true;
                        break;

                    // Not sure how to account for different spellings yet, so created another case
                    case "Spider Man":
                        Console.WriteLine("Me Too!! Did we just become best friends!?");
                        rightAnswer = true;
                        break;

                    // Not sure how to account for different spellings yet, so created another case
                    case "Spiderman":
                        Console.WriteLine("Me Too!! Did we just become best friends!?");
                        rightAnswer = true;
                        break;

                    default:
                        Console.WriteLine("Really...? There's definitely one better than that.");
                        answer = Console.ReadLine();
                        break;
                }

            }

            while (!rightAnswer);
            Console.ReadLine();
        }
    }
}

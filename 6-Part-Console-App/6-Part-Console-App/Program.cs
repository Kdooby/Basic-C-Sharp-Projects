using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Part_Console_App
{
    class Program
    {
        public static object Evironment { get; private set; }

        static void Main(string[] args)
        {
            //// PART 1 \\

            //string[] userText = new string[5];  // string list containing up to 6 indices

            //for (int i = 0; i < 5; i++)  // for i is liess than 6, add to the array
            //{
            //    Console.WriteLine("Input some text to add to the array: ");
            //    userText[i] = Console.ReadLine();  

            //}
            //foreach (string i in userText)
            //{
            //    Console.WriteLine(i);

            //}
            //Console.ReadLine();





            //// PART 2 \\

            //for (int i = 0; i >= 0; i++)  //// As long as the condition i is greater than 0, it will keep looping
            //{
            //    Console.WriteLine(i + " is part of this infiniate loop!");
            //}
            //Console.ReadLine();


            //// FIX INFINATE LOOP \\

            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine(i + " out of 10!");
            //}
            //Console.ReadLine();





            //// PART 3 \\

            //int i = 0;

            //while (i < 15)
            //{
            //    Console.WriteLine("We have reached the < operateror " + i + " times");
            //    i++;
            //}
            //Console.ReadLine();


            //int j = 0;

            //while (j <= 15)
            //{
            //    Console.WriteLine("We have reached the <= operateror " + j + " times");
            //    j++;
            //}
            //Console.ReadLine();




            //// PART 4 \\

            //List<string> animals = new List<string>() { "giraffe", "monkey", "horse", "tiger", "elephant", "rhino" };

            //Console.WriteLine("Input a type of animal to see if it's on the list: ");
            //string input = Console.ReadLine();
            //bool animal = false;

            //while (animal == false)
            //{
            //    for(int a = 0; a <= 5; a++) // for each animal  in the list of animals
            //    {
            //        if (animals[a] == input) // if the user input equals an animal from the list
            //        {
            //            Console.WriteLine("You got the animal at index: " + a + "!");  // prints index
            //            animal = true; //animal now equals true, stops the loop. 
            //            break; // also stops the loop, but not needed with the line above.  It is however a better visual of where the loop will end. 

            //        }
            //    }

            //    if (!animal)
            //    {
            //        Console.WriteLine(); // Line Break
            //        Console.WriteLine("Your input was not compatible. Try again. ");
            //        Console.WriteLine("Input a type of animal to see if it's on the list: ");
            //        input = Console.ReadLine();
            //        Console.WriteLine(); // Line Break
            //    }
            //}
            //Console.ReadLine();





            //// PART 5  AND  PART 6  \\

            List<string> fruits = new List<string>() { "apple", "banana", "orange", "apple", "plum", "grape", "banana" };
            Console.WriteLine("Enter a fruit to search for: ");
            string input = Console.ReadLine();
            bool fruit = false;

            while (fruit == false)
            {
                for (int f = 0; f <= 6; f++)
                {
                    if (fruits[f] == input)
                    {
                        Console.WriteLine("This fruit has the index of: " + f);
                        fruit = true;
                    }
                }

                if (!fruit)
                {
                    Console.WriteLine(); // Line Break
                    Console.WriteLine("This fruit does not appear in the Fruit Bowl.");
                    Console.WriteLine("Enter a fruit to search for: ");
                    input = Console.ReadLine();
                    Console.WriteLine(); // Line Break
                }
            }

            Console.ReadLine();

            List<string> fruitBowl = new List<string>();  // empty string to store items

            foreach (string f in fruits) // for each fruit in fruits
            {
                if (fruitBowl.Contains(f)) // if fruitbowl contains duplicate fruit
                {
                    Console.WriteLine(f + "'s are already in the bowl.  Eat one!");
                }

                else
                {
                    fruitBowl.Add(f); // if fruitbowl doesn't contain fruit already, add to list
                    Console.WriteLine(f + "'s are in the Fruit Bowl.");
                }
                
            }
            Console.ReadLine();
                
        }
    }
}




using System;
using System.Collections.Generic;




    class Program
    {
    static void Main()
    {
        // STRING ARRAY

        string[] Array1 = { "Helicopter", "Car", "Airplane", "Boat", "Spaceship", "Hover Board" };
        Console.WriteLine("Depending on which index you choose will determine what your next mode of transportation will be.");
        Console.WriteLine("Choose an index between 0 and 5: ");
        int wordInput = Convert.ToInt32(Console.ReadLine());

        while (wordInput < 0 || wordInput >= 6) //if input is less than 0 or greater than/equal to 6
        {
            Console.WriteLine("This is not a correct index value.");
            Console.WriteLine("Choose an index between 0 and 5: ");
            wordInput = Convert.ToInt32(Console.ReadLine());

        }

        Console.WriteLine("You chose " + Array1[wordInput] + "!");
        Console.ReadLine();

        Console.WriteLine(); //line break



        // INTEGER ARRAY

        int[] Array2 = { 5, 10, 15, 20, 25, 30, };
        Console.WriteLine("Choose an index between 0 and 5 to display the number.");
        int numInput = Convert.ToInt32(Console.ReadLine());

        while (numInput < 0 || numInput >= 6) //if input is less than 0 or greater than/equal to 6
        {
            Console.WriteLine("This is not a correct index value.");
            Console.WriteLine("Choose an index between 0 and 5 to display the number.");
            numInput = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine("The number you chose is " + Array2[numInput] + "!");
        Console.ReadLine();

        Console.WriteLine(); //line break




        // STRING LIST

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Bonjour");
        stringList.Add("Hola");
        stringList.Add("Kon'nichiwa");
        stringList.Add("Aloha");

        Console.WriteLine("Choose an index between 0 and 5 to be greeted in a specific langauage");
        int greetInput = Convert.ToInt32(Console.ReadLine());

        while (greetInput < 0 || greetInput >= 6) //if input is less than 0 or greater than/equal to 6
        {
            Console.WriteLine("This is not a correct index value.");
            Console.WriteLine("Choose an index between 0 and 5 to be greeted in a specific langauage");
            greetInput = Convert.ToInt32(Console.ReadLine());

        }
        Console.WriteLine(stringList[greetInput] + "!");
        Console.ReadLine();




    }


    }




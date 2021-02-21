using System;
using System.IO;

namespace TwentyOne
{
    internal class Program
    {
        private static void Main(string[] args)
        { 
            Console.WriteLine("\nDEALER: Howdy stranger! You made it to Tumbleweed's Hotel and Casino!");
            Console.Write("\nDEALER: Let's start by telling me your name\nPLAYER: ");
            string playerName = Console.ReadLine().ToUpper();

            Console.Write("\n\n\nDEALER: Welcome {0}!  How much money did you bring today?\nPLAYER: $", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDEALER: That there is plenty!");
            Console.Write("\n\n\nDEALER: Would you like hunker down and join a game of 21?\nPLAYER: ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                || answer == "yessir" || answer == "sure")
            {
                Console.WriteLine("\nDEALER: Great! Have yourself a drink while you're at it.  Free of charge while you're at the table.");
                Player player = new Player(playerName, bank); // New Player object.  Initalized with name and funds (from Player Constructor)
                Game game = new TwentyOneGame(); // Create New Game.  Polymorphism
                game += player;  // Adding Player to Game
                player.IsActivelyPlaying = true;  // While Player is actively playing, and balance is above 0, play the game
                while (player.IsActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                while (player.IsActivelyPlaying && player.Balance <= 0)
                {
                    Console.WriteLine("\nDEALER: Unfortunatly, you do not have anymore money to gamble with...");
                    player.IsActivelyPlaying = false;
                }
            }
            Console.WriteLine("\nDEALER: Thank you for playing, {0}.", playerName);
            Console.WriteLine("DEALER: Come on back now, when you're ready!");
            Console.Read();
        }
    }
}

                
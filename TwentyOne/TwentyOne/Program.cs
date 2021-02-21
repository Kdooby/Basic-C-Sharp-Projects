using System;

namespace TwentyOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t\t\t*-*-*-*-*-*TUMBLEWEED'S GAMBLING HALL*-*-*-*-*-*\n\n");
            Console.ReadLine();

            Console.WriteLine("\tIt's a hot summer's day as you're walking the road.  Covered in sweat and the reminence of a hard day's work." +
                "\n\tYou have a little more pep in your step than usual, however, and your pockets\n\tare a little heavier too, it being Pay Day and all." +
                "\n\tThe Boss-Man gave you a little extra for how hard you've been workin' the last few months down in the Mines!" +
                "\n\tYou tell yourself that you probably should save it for a rainy day, or something nice for the Mrs.. \n\tWell, that's what the Mrs. would want at least.\n" +
                "\n\tBut today is different...You can feel it deep in your boots.\n" +
                "\n\tToday, you're feeling lucky...Aren't you punk?\n" +
                "\n======================================================================================================================\n" +
                "======================================================================================================================\n");
            Console.ReadLine();

            Console.WriteLine("\tAfter what seems like all afternoon, you finally get to where your feet are taking you.\n" +
                "\tYou gaze up at the large sign above the entrance way. Your eyes battle with the sun, trying to read what it says.");
            Console.ReadLine();

            Console.WriteLine("\nDEALER: Howdy stranger! You made it to Tumbleweed's Gambling Hall! Come on in and get out of that sun!");
            Console.ReadLine();

            Console.WriteLine("\n\tYour eyes look down and peer passed the wood doors into the building." +
                "\n\tYou can hear the sound of ragtime coming from the piano inside, and your feet can't help but tap along.");
            Console.ReadLine();

            Console.WriteLine("\tYou enter the Hall and walk toward the Dealer that called you in." +
                "\n\tThe smell of cigar smoke and stale alcohol fills the air, but this only calms your nerves.");
            Console.ReadLine();

            Console.Write("\nDEALER: What's your name there fella?\nPLAYER: ");
            string playerName = Console.ReadLine().ToUpper();

            Console.Write("\nDEALER: Welcome {0}!  You look like you have Lady Luck blessin' you today!" +
                "\nMaybe your purse is a little heavier than usual...?" +
                "\nHow much money you reckonin' to bet with anyhow?\n{0}: $", playerName);
            int bank = Convert.ToInt32(Console.ReadLine());
            if (bank >= 100)
            {
                Console.WriteLine("\n\n\tThe Dealer grins and eye's your coin purse, and then back up to you.\n");
                Console.ReadLine();
                Console.WriteLine("DEALER: I didn't know we was dealing with such a High Roller!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n\n\tThe Dealer's friendly smile turns to a frown as he eye's your coin purse.\n");

                Console.ReadLine();
                Console.WriteLine("DEALER: Well, having a High Roller in these parts are far and between these days" +
                    "\nLet's see if fortune will favor the brave today!");
                Console.ReadLine();
            }

            Console.Write("DEALER: Would you like to hunker down and try your hand at a game of BlackJack?\n{0}: ", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                || answer == "yessir" || answer == "sure" || answer == "ok" || answer == "okay")
            {
                Console.WriteLine("\nDEALER: Great! Have yourself a drink while you're at it.  Free of charge while you're at the table.");
                Console.ReadLine();
                Console.Write("Would you like a drink?\n{0}: ", playerName);
                string drink = Console.ReadLine().ToLower();
                if (drink == "yes" || drink == "yeah" || drink == "y" || drink == "ya"
                    || drink == "yessir" || drink == "sure" || drink == "ok" || drink == "okay")
                {
                    Console.WriteLine("\n\tOne of the Lady's of the Hall pours you a whiskey and brings it over." +
                        "\n\tYou tip your hat to her and smile as she walks away.");
                    Console.ReadLine();
                }
                else
                {
                    Console.Write("\nDEALER: Ah!  Like to stay sharp do ya?  I respect that." +
                        "\nWhen it comes to one's money, a sharper mind will keep you in line.");
                    Console.ReadLine();
                }

                Console.WriteLine("\nDEALER: Alright now.  Good Luck!");
                Console.Read();
                Console.WriteLine("\n======================================================================================================================\n" +
                "======================================================================================================================\n");
                Console.Read();

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
            Console.WriteLine("\nDEALER: Thank you for comin' in today, {0}.  We appreciate your business! ", playerName);
            Console.WriteLine("DEALER: Come on back now, you hear!?");
            Console.Read();
        }
    }
}
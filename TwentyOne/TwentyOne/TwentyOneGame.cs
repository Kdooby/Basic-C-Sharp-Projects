﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            // NEW GAME
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>(); // Each Player gets a new hand
                player.Stay = false; // Reset Stay to  False
            }
            Dealer.Hand = new List<Card>(); // Dealer gets new Hand
            Dealer.Stay = false; // Reset Stay to  False
            Dealer.Deck = new Deck(); // Dealer gets new Deck of Cards
            Dealer.Deck.Shuffle();
            Console.Write("\n\n\nPlace your bet:\n$");

            // PLAYER MAKES BET
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet); // Passing in amount they entered, into the Bet method
                if (!successfullyBet) // if false
                {
                    return;
                }
                Bets[player] = bet;  // Bets = Dictionary,  [player] = Key, bet = Value
            }

            // DEALING CARDS
            for (int i = 0; i < 2; i++)  // Dealing twice
            {
                Console.WriteLine("\nDealing...\n");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name); // Console.Write, writes something to console, but doesnt automatically press enter.  No new line.
                    Dealer.Deal(player.Hand);
                    if (i == 1) // second round of cards

                    {    // BlACKJACK
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("YOUR CARDS: ");
                            foreach (Card card in player.Hand)
                            {
                                Console.Write("{0}", card.ToString());
                            }
                            Console.WriteLine("\nHot Damn! BlackJack! We have a real Gun Slinger here!\n{0}, you won ${1}! ", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // win your bet + 1.5, PLUS your own bet back
                            Console.WriteLine("\nYour balance is now ${1}", Bets[player], player.Balance);
                            Console.WriteLine("\nDo you want to try your luck again?");
                            string answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                                || answer == "yessir" || answer == "sure")
                            {
                                player.IsActivelyPlaying = true;
                                return;
                            }
                            else
                            {
                                player.IsActivelyPlaying = false;
                                return;
                            }
                        }
                    }
                }
                Console.Write("DEALER: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("\n\nDEALER'S CARDS:");
                        foreach (Card card in Dealer.Hand)
                        {
                            Console.Write("{0}", card.ToString());
                        }
                        Console.WriteLine(); //Line Break

                        Console.WriteLine("\nLooks like the Dealer got BlackJack! Sorry folks, better luck next time.");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;  // adds everyone's bets to the Dealer's balance.
                            foreach (Player player in Players)
                            {
                                Console.WriteLine("\nYour balance is now ${1}", Bets[player], player.Balance);
                                Console.WriteLine("\nDo you want to try your luck again?");
                                string answer = Console.ReadLine().ToLower();
                                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                                    || answer == "yessir" || answer == "sure")
                                {
                                    player.IsActivelyPlaying = true;
                                    return;
                                }
                                else
                                {
                                    player.IsActivelyPlaying = false;
                                    return;
                                }
                            }
                        }
                        return;
                    }
                }
            }

            // STAY AND HIT

            foreach (Player player in Players)
            {
                while (!player.Stay) // While Player doesn't Stay
                {
                    Console.WriteLine("\n\nYOUR CARDS: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}", card.ToString());
                    }

                    Console.WriteLine("\n\n\nHIT or STAY?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay" || answer == "s")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit" || answer == "h")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("\nOh dear...Looks like {0} busted.", player.Name);
                        Console.WriteLine("You lose your bet of ${0}.  Your balance is now ${1}", Bets[player], player.Balance);
                        Console.WriteLine("\nDo you want to try your luck again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                            || answer == "yessir" || answer == "sure")
                        {
                            player.IsActivelyPlaying = true;
                            return;
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                            return;
                        }
                    }
                }
            }

            // BUSTED
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted) // While Dealer doesn't Stay and isn't busted
            {
                Console.WriteLine("\n\nDealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("\n\nDEALER'S CARDS:");
                foreach (Card card in Dealer.Hand)
                {
                    Console.Write("{0}", card.ToString());
                }
                Console.WriteLine(); //Line Break
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("\n\nDEALER'S CARDS:");
                foreach (Card card in Dealer.Hand)
                {
                    Console.Write("{0}", card.ToString());
                }
                Console.WriteLine(); //Line Break

                Console.WriteLine("\nThe Dealer has Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("\nLook at that Luck! {0} won ${1}!", entry.Key.Name, entry.Value);  //Key is (player) and has Name.
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                foreach (Player player in Players)
                {
                    Console.WriteLine("Your balance is now ${1}", Bets[player], player.Balance);
                    Console.WriteLine("\nDo you want to try your luck again?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                        || answer == "yessir" || answer == "sure")
                    {
                        player.IsActivelyPlaying = true;
                        return;
                    }
                    else
                    {
                        player.IsActivelyPlaying = false;
                        return;
                    }
                }
            }

            // COMPARE HANDS
            foreach (Player player in Players)
            {
                // ? turns bool datatype to accept "null"
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("\nThat there is a Push! No one wins this round.");
                    player.Balance += Bets[player]; // Player get their bet back
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("\nThat was close!  Great Job!");
                    Console.WriteLine("{0}, you have won ${1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("\nOh my, looks like the Dealer came out ahead this time.");
                    Console.WriteLine("The Dealer has won ${0}!\n", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("\nYour balance is now ${1}", Bets[player], player.Balance);
                Console.WriteLine("\nDo you want to try your luck again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya"
                    || answer == "yessir" || answer == "sure")
                {
                    player.IsActivelyPlaying = true;
                    return;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                    return;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("\"21\" Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); // If method is called, throws this error
        }
    }
}
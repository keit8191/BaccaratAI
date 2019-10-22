using System;
using System.Collections.Generic;
using System.Text;

namespace BaccaratAI
{
    public class Game
    {
        private Player Player1;
        private Player Player2;

        public Game(string player1name, string player2name)
        {
            Player1 = new Player(player1name);
            Player2 = new Player(player2name);

            var cards = DeckCreator.CreateCards(); //Returns a shuffled set of cards

            var deck = Player1.Deal(cards);


        }



        public void PlayTurn()
        {
            char input;
            //var playercard1 = Player1.Deck.Dequeue();
            //var playercard2 = Player1.Deck.Dequeue();
            //var dealercard1 = Player1.Deck.Dequeue();
            //var dealercard2 = Player1.Deck.Dequeue();
            //var playercard3 = Player1.Deck.Dequeue();
            //var dealercard3 = Player1.Deck.Dequeue();

            
            //Console.WriteLine(Player2.Name + " Has " + dealercard1.DisplayName);
            //if (dealercard1.Value == 9)
            //{
            //    Console.WriteLine("Dealer checks for natural 9 ");
            //    Console.WriteLine("Dealer's second card is " + dealercard2.DisplayName);
            //    if (dealercard2.Value == 11 || dealercard2.Value == 12 || dealercard2.Value == 13)
            //    {
            //        Console.WriteLine("Dealer had natural 9! Dealer wins.");
            //        Console.Read();
            //    }
            //}
            //if (playercard1.Value == 9)
            //{
            //    if (playercard2.Value == 11 || playercard2.Value == 12 || playercard2.Value == 13)
            //    {
            //        Console.WriteLine("Player has natural 9! Player wins.");
            //        Console.Read();
            //    }
            //}
            //if (playercard2.Value == 9)
            //{
            //    if (playercard1.Value == 11 || playercard1.Value == 12 || playercard1.Value == 13)
            //    {
            //        Console.WriteLine("Player has natural 9! Player wins.");
            //        Console.Read();
            //    }
            //}
            //Console.WriteLine(Player1.Name + " Has " + playercard1.DisplayName + " and " + playercard2.DisplayName);
            //int ptotal = 0;
            //if (playercard1.Value == 11 || playercard1.Value == 12 || playercard1.Value == 13)
            //{
            //    ptotal += 0;
            //}
            //if (playercard1.Value == 14)
            //{
            //    ptotal += 1;
            //}
            //if (playercard2.Value == 11 || playercard2.Value == 12 || playercard2.Value == 13)
            //{
            //    ptotal += 0;
            //}
            //if (playercard2.Value == 14)
            //{
            //    ptotal += 1;
            //}
            //if (playercard1.Value <= 10 && playercard1.Value >= 2)
            //{
            //    ptotal += playercard1.Value;
            //}
            //if (playercard2.Value <= 10 && playercard2.Value >= 2)
            //{
            //    ptotal += playercard2.Value;
            //}
            //ptotal = ptotal % 10;
            //int dtotal = 0;
            //if (dealercard1.Value == 11 || dealercard1.Value == 12 || dealercard1.Value == 13)
            //{
            //    dtotal += 0;
            //}
            //if (dealercard1.Value == 14)
            //{
            //    dtotal += 1;
            //}
            //if (dealercard2.Value == 11 || dealercard2.Value == 12 || dealercard2.Value == 13)
            //{
            //    dtotal += 0;
            //}
            //if (dealercard2.Value == 14)
            //{
            //    dtotal += 1;
            //}
            //if (dealercard1.Value <= 10 && dealercard1.Value >= 2)
            //{
            //    dtotal += dealercard1.Value;
            //}
            //if (dealercard2.Value <= 10 && dealercard2.Value >= 2)
            //{
            //    dtotal += dealercard2.Value;
            //}
            //dtotal = dtotal % 10;
            //Console.WriteLine(Player1.Name + " Has a total of: " + ptotal);
            //Console.WriteLine("Enter s to stay or d to draw an additional card.");
            Decision decision = new Decision();
            int p1, p2, d1;
            Console.WriteLine("Enter the player's first card. ");
            p1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the player's second card. ");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the dealer's card. ");
            d1 = Convert.ToInt32(Console.ReadLine());
            decision.DecisionAI(p1, p2, d1);
            Console.WriteLine("AI Chose: " + decision.decision);
            Console.ReadLine();
            

            //input = Console.ReadKey().KeyChar;
            //if (input == 's')
            //{
            //    Console.WriteLine("\nDealer second card is " + dealercard2.DisplayName + " Dealer total is: " + dtotal);
            //    if (dtotal <= 4)
            //    {
            //        Console.WriteLine("Dealer draws " + dealercard3.DisplayName);
            //        if (dealercard3.Value == 11 || dealercard3.Value == 12 || dealercard3.Value == 13)
            //        {
            //            dtotal += 0;
            //        }
            //        if (dealercard3.Value == 14)
            //        {
            //            dtotal += 1;
            //        }
            //        if (dealercard3.Value <= 10 && dealercard3.Value >= 2)
            //        {
            //            dtotal += dealercard3.Value;
            //        }
            //        dtotal = dtotal % 10;
            //        if (dtotal > ptotal)
            //        {
            //            Console.WriteLine("Dealer Wins!");
            //            Console.WriteLine("AI's Decision was: " + decision.decision);
            //            Console.Read();
            //        }
            //        else if (ptotal > dtotal)
            //        {
            //            Console.WriteLine("Player wins!");
            //            Console.WriteLine("AI's Decision was: " + decision.decision);
            //            Console.Read();
            //        }
            //        else
            //        {
            //            Console.WriteLine("It's a tie!");
            //            Console.WriteLine("AI's Decision was: " + decision.decision);
            //            Console.Read();
            //        }
                    
            //    }
            //}
            //else if (input == 'd')
            //{
            //    Console.WriteLine("\nPlayer draws: " + playercard3.DisplayName);
            //    if (playercard3.Value == 11 || playercard3.Value == 12 || playercard3.Value == 13)
            //    {
            //        ptotal += 0;
            //    }
            //    if (playercard3.Value == 14)
            //    {
            //        ptotal += 1;
            //    }
            //    if (playercard3.Value <= 10 && playercard3.Value >= 2)
            //    {
            //        ptotal += playercard3.Value;
            //    }
            //    ptotal = ptotal % 10;
            //    Console.WriteLine("Player total is: " + ptotal);
            //    Console.WriteLine("Dealer's second card is: " + dealercard2.DisplayName);
            //    Console.WriteLine("Dealer total is: " + dtotal);
            //    if (dtotal <= 4)
            //    {
            //        Console.WriteLine("Dealer draws " + dealercard3.DisplayName);
                    
            //        if (dealercard3.Value == 11 || dealercard3.Value == 12 || dealercard3.Value == 13)
            //        {
            //            dtotal += 0;
            //        }
            //        if (dealercard3.Value == 14)
            //        {
            //            dtotal += 1;
            //        }
            //        if (dealercard3.Value <= 10 && dealercard3.Value >= 2)
            //        {
            //            dtotal += dealercard3.Value;
            //        }
            //        dtotal = dtotal % 10;
            //        Console.WriteLine("Dealer total: " + dtotal);
            //    }
            //    if (dtotal > ptotal)
            //    {
            //        Console.WriteLine("Dealer Wins!");
            //        Console.WriteLine("AI's Decision was: " + decision.decision);

            //    }
            //    else if (ptotal > dtotal)
            //    {
            //        Console.WriteLine("Player wins!");
            //        Console.WriteLine("AI's Decision was: " + decision.decision);

            //    }
            //    else
            //    {
            //        Console.WriteLine("It's a tie!");
            //        Console.WriteLine("AI's Decision was: " + decision.decision);

            //    }
            //    Console.Read();
            //}

            }
        }
    }



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaccaratAI
{
   public class Decision
    {
        public string decision;
        public void DecisionAI(int playercard1, int playercard2, int dealercard1)
    {
            var cards = DeckCreator.CreateCards();
            var deck = cards.ToList();
            int positive=0;
            int negative = 0;
            int neutral = 0;
            int ptotal=(playercard1 + playercard2) % 10;
         
            int index;


            if (playercard1 == 1)
            {
                index = deck.FindIndex(startIndex: 0, count: 52, match: x => x.DisplayName.StartsWith("A"));
            }
            else
            {
                index = deck.FindIndex(startIndex: 0, count: 52, match: x => x.DisplayName.StartsWith(Convert.ToString(playercard1)));
            }
            deck.RemoveAt(index);
            if (playercard2 == 1)
            {

                index = deck.FindIndex(startIndex: 0, count: 51, match: x => x.DisplayName.StartsWith("A"));
            }
            else
            {
                index = deck.FindIndex(startIndex: 0, count: 51, match: x => x.DisplayName.StartsWith(Convert.ToString(playercard2)));
            }
            deck.RemoveAt(index);
            if (dealercard1 == 1)
            {
                index = deck.FindIndex(startIndex: 0, count: 50, match: x => x.DisplayName.StartsWith("A"));
            }
            else
            {
                index = deck.FindIndex(startIndex: 0, count: 50, match: x => x.DisplayName.StartsWith(Convert.ToString(dealercard1)));
            }
            for (int i=0; i<deck.Count; i++)
            {
                if(deck[i].Value>=2 && deck[i].Value <= 10)
                {
                    if (deck[i].Value + ptotal <= 9)
                    {
                        positive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
                if(deck[i].Value==11 || deck[i].Value == 12 || deck[i].Value == 13)
                {
                    neutral++;
                }
                if (deck[i].Value == 14)
                {
                    if (ptotal + 1 <= 9)
                    {
                        positive++;
                    }
                    else
                    {
                        negative++;
                    }
                }
            }
            if (positive > negative)
            {
                decision = "Draw";
            }
            else
            {
                decision = "Stay";
            }
        }
    }
}

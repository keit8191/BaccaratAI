using System;
using System.Collections.Generic;
using System.Text;

namespace BaccaratAI
{
    public static class Extensions
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newcards)
        {
            foreach (var card in newcards)
            {
                cards.Enqueue(card);
            }
        }
    }
}

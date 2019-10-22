using System;
using System.Collections.Generic;
using System.Linq;

namespace BaccaratAI
{



    class Program
    {
     
        static void Main(string[] args)
        {
            Game game = new Game("Player", "Dealer");
            game.PlayTurn();
        }
    }
}

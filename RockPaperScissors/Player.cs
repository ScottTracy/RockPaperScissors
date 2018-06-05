using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public int score;
        public string name;
        public Player()
        {

        }

        public virtual void SetName(Player player, int playerNumber )
        {
            Console.WriteLine("What is the name of player" +(playerNumber) + "?");
            player.name = Console.ReadLine();
        }
        public abstract int MakeChoice(Player player, List<string> gestures);
      
        public void InformUser(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

    }

}

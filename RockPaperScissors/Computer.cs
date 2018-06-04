using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        public override int MakeChoice(Player player, List<string> gestures)
        {
            Random rnd = new Random();
            int userChoice = rnd.Next(5);

            return userChoice;
        }
        public override void SetName(Player player, string PlayerNumber)
        {
            player.name = "Computer";
        }
    }
}

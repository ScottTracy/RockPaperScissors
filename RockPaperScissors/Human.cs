using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        public Human()
        {

        }
        public override int MakeChoice(Player player, List<string> gestures)
        {
            Console.WriteLine(player.name + "'s turn. Choose a number corresponding to the gesture you would like to use.");
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + gestures[i]);
            }
            int userChoice = (int.Parse(Console.ReadLine()) - 1);
            if (userChoice <= gestures.Count && userChoice >= 0)
            {
                InformUser(player.name + " chooses " + gestures[userChoice]);
            }
            else
            {
                MakeChoice(player, gestures);
            }
            return userChoice;

        }
    }
}

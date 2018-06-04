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

        public virtual void SetName(Player player, int playerNumber )
        {
            Console.WriteLine("What is the name of player" +(playerNumber) + "?");
            player.name = Console.ReadLine();
        }
        public virtual int MakeChoice(Player player, List<string> gestures)
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
        public void InformUser(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

    }

}

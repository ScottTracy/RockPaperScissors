using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    public class Game
    {
        public List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        
        public int[,] winningGestureKeyKey = new int[,] { { 2, 4 }, { 0, 3 }, { 1, 4 }, { 0, 2 }, { 1, 3 } };
        Player player1;
        Player player2;

        public Game()
        {
        }

        public void DetermineWinner(int player1Choice, int player2Choice)
        {
            if (player1Choice == player2Choice)
            {
                InformUser("Draw!  press <enter>  to continue");
                DetermineWinner(player1.MakeChoice(player1,gestures), player2.MakeChoice(player2,gestures));
            }
            else if (player2Choice == winningGestureKeyKey[player1Choice,0 ] || player2Choice == winningGestureKeyKey[player1Choice, 1])
            {
                UpdateWinner(player1);
            }
            else
            {
                UpdateWinner(player2);
            }                              
        }
        public void InformUser(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }
        public void UpdateWinner(Player winner)
        {
            int newScore = winner.score + 1;
            winner.score = newScore;
            InformUser(winner.name + " wins round !");
            if (newScore == 2)
            {
                InformUser(winner.name + " won the game!  press <Enter> to start a new game.");
                StartGame(); 
            }
            else
            {
                DetermineWinner(player1.MakeChoice(player1, gestures), player2.MakeChoice(player2, gestures));
            }

        }       
        public void SetPlayers()
        {
            Console.WriteLine("How many players? (1 or 2)");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberOfPlayers == 0)
            {
                player1 = new Computer();
                player2 = new Computer();
            }
            else
            {
                SetPlayers(); 
            }

        }
        public void StartGame()
        {
            SetPlayers();
            player1.SetName(player1, 1);
            player2.SetName(player2, 2);
            DetermineWinner(player1.MakeChoice(player1, gestures), player2.MakeChoice(player2, gestures));
        }

    }
}

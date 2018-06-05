using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Gestures
    {
        public int[,] winningGestureKeyKey = new int[,] { { 2, 4 }, { 0, 3 }, { 1, 4 }, { 0, 2 }, { 1, 3 } };
        public Dictionary<int,int[]>winningGestures = new Dictionary<int, int[]>();
public Gestures()
        {
                
        }

        public void MakeDictionary()
        {
            for (int i = 0; i < 5; i++)
            {
                int[] array = new int[] { winningGestureKeyKey[i, 0], winningGestureKeyKey[i, 1] };
                winningGestures.Add(i, array);
                
            }
            
        }

    }
}

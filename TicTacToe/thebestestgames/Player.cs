using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thebestestgames
{
    internal class Player
    {
        public PictureBox[] playerPositions { get; set; }

        public Player(PictureBox[] possibleplayerpositions, int startpos)
        {
            playerPositions = possibleplayerpositions;
            ResetDisplay();
            playerPositions[startpos].Visible = true;
        }

        public void move(int newpos)
        {
            if(validateMove(newpos))
            {
                ResetDisplay();
                playerPositions[newpos].Visible = true;
            }
          
        }

        public bool validateMove(int newpos)
        {
            if ( newpos < 0 || playerPositions == null || newpos > playerPositions.Length - 1) 
            {
                return false;
            }


            return true;
        }

        private void ResetDisplay()
        {
            for (int i = 0;i < playerPositions.Length; i++)
            {
                playerPositions[i].Visible = false;
            }
        }

    }
}

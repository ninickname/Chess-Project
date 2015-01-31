using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Queen : Figure
    {

        public Queen(Location baseLocation, Board board, Player player) : base(baseLocation, board, player) { }
    
        public override string canEatAt(Location targetLocation)
        {
            return canBeMoved(targetLocation);
        }
        /*try to eat , checking if the move is legal */
        public override string canBeMoved(Location newLocation)
        {
            /* well here i try to be "smarter than im supposed to be" 
             * and trying to avoud the copy paste , that is not that nessesery at this location . 
             * my plan is to create a bishop and a rook with the same coordinates of the queen , check if they can be moved to a certain location , if one of the can VIOLA ! 
             * if non can , than just throw them away and return false , the only important thing is to follow exceptions that can fly here from corner to corner 
             */

            Rook rook = new Rook(this);

            if (rook.canBeMoved(newLocation) == "true")
                return "true";
            else
            {
                Bishop bi = new Bishop(this);
                return bi.canBeMoved(newLocation);
            }
        }


        public override string toString()
        {
            return "Q";
        }


    }
}

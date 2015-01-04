using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Pawn : Figure
    {
        public bool direction;


        public int dir = -1;
        public int start = 7;//the "default is that the location is down , and if its up , flip the coins"
        public int end = 2;

        public Pawn(Location baseLocation, bool direction, Board board, Player player)
            : base(baseLocation, board, player)
        {
            this.direction = direction;

            if (this.direction == UP)
            {
                dir = 1;
                start = 2;
                end = 7;
            }
            /* well i added the magic , should just test it a bit later */

        }


        public override string canEatAt(Location targetLocation)
        {
            /**/


            /*normal numnum , someone is on the front left or on the front right */
            if ( Math.Abs(targetLocation.x - location.x )==1 && targetLocation.y == location.y + 1 * dir)
            {//checking if this is the first move , and if there is something that can interrupt my double move
                Console.WriteLine("just a regular NUMNUMNUM ");
                return "true";
            }
            
            if ( (Math.Abs(targetLocation.x - location.x) == 1 && targetLocation.y == location.y + 1 * dir)// this move has the right 
                && board.previousMove.to.y == board.previousMove.from.y - 2*dir  // the last move was double sized
                && board.previousMove.to.x == location.x            //these lines  
                && board.previousMove.to.y == location.y - 1 * dir  //promise that the move is completley legit 
                )
            {//checking if this is the first move , and if there is something that can interrupt my double move
                Console.WriteLine("just a regular NUMNUMNUM ");
                return "true";
            }
            







        /* a whole new world of shitttt*/
            return " this pile of poo is not ready ! _@!#*$)(!@#&$(";
        }
        /*try to eat , checking if the move is legal */
        public override string canBeMoved(Location newLocation)
        {
            /* this function returns if the figure can be moved to the specified location , 
             * if it can be it is moved and returns true
             * if the move is not legal throws illigal move execption
             * 
             * the location that the function expects to recieve is after a confurmation that this location is not occupied
             */

            /**i should  also add i whitch will be index of direction whitch will do the  +1 -1 magic ... but furst finnish all the legal moves for this mob*/


            /*first double move*/
            if (location.y == start && newLocation.x == location.x && newLocation.y == location.y + 2 * dir)
            {//checking if this is the first move , and if there is something that can interrupt my double move
                Console.WriteLine(" the move is legal . just getting your Panw farward to victory ! ");
                return "true";

            }
            /*special move when the pawn becomes something great*/
            if (location.x == end && newLocation.x == location.x && newLocation.y == location.y + dir)
            {//checking if this is the first move , and if there is something that can interrupt my double move
                return "this pile of poo requirs special treatment";
            }


            /*just a normal move*/
            if (newLocation.x == location.x && newLocation.y == location.y + dir)
            {
                Console.WriteLine(" the move is legal . just getting your Panw farward to victory ! ");
                return "true";
            }

           return "false";
        }


        public override string toString()
        {
           return "p";
        }

    }
}

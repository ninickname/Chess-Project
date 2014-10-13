using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Figures
{
    public class Pawn : Figure
    {



        public override bool canBeMoved(Location newLocation)
        {
            /* this function returns if the figure can be moved to the specified location , 
             * if it can be it is moved and returns true
             * if the move is not legal throws illigal move execption
             * 
             * the location that the function expects to recieve is after a confurmation that this location is not occupied
             */


            /**i should  also add i whitch will be index of direction whitch will do the  +1 -1 magic ... but furst finnish all the legal moves for this mob*/
            
            int i = -1;
            int start = 7;//the "default is that the location is down , and if its up , flip the coins"
            int end = 2;

            if (this.direction == UP)
            {
                i = 1;
                start = 2;
                end = 7;
            }
            /* well i added the I magic , shouold just test it a bit later */
 
                /*first double move*/
                if (location.x == start && newLocation.x == location.x && newLocation.y == location.y + 2*i && board.isEmpty(newLocation) )
                {//checking if this is the first move , and if there is something that can interrupt my double move
                    Console.WriteLine(" the move is legal . just getting your Panw farward to victory ! ");
                    return true;

                }
                /*special move when the pawn becomes something great*/
                if (location.x == end  && newLocation.x == location.x && newLocation.y == location.y + i  )
                {//checking if this is the first move , and if there is something that can interrupt my double move
                    throw new PawnGrewUp(this);
                }


                /*just a normal move*/
                if (newLocation.x == location.x && newLocation.y == location.y + i  ){
                    Console.WriteLine(" the move is legal . just getting your Panw farward to victory ! ");
                    return true;
                }
            

            throw new IllegalMoveExeption(); // temp might be found as 'unnecessary ' 
            //return false;
        }

        public override bool eatAt(Location targetLocation) {


            return false;
        
        
        }

    }
}

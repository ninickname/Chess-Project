﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Figures
{
    public class Pawn : Figure
    {



        public override bool move(Location newLocation)
        {
            /* this function returns if the figure can be moved to the specified location , 
             * if it can be it is moved and returns true
             *  if the move is not legal returns false and doesent move the figure */



            /**i should  also add i whitch will be index of direction whitch will do the  +1 -1 magic ... but furst finnish all the legal moves for this mob*/
            if (this.direction == UP) { 
                
                /*special case when the pawn eats something*/
                if (newLocation.x == location.x && newLocation.y == location.y + 1 && board.isEmpty(newLocation) && newLocation.y == Location.END_OF_BOARD_TOP )
                {
                
                
                
                }



                /*special move when the pawn becomes something great*/




                /*just a normal move*/
                if (newLocation.x == location.x && newLocation.y == location.y + 1 && board.isEmpty( newLocation ) ){
                    Console.WriteLine(" the move is legal . just getting your Panw farward to victory ! ");
                    return true;
                }


            }

            return false;
        }


    }
}

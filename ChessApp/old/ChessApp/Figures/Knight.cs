﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Knight : Figure
    {
                

        public Knight(Location baseLocation, Board board, Player player) : base(baseLocation, board, player) { }


        public override string canEatAt(Location targetLocation)
        {
      return canBeMoved(targetLocation);

        }
        /*try to eat , checking if the move is legal */
        public override string canBeMoved(Location newLocation)
        {
            if ( ( Math.Abs(location.x - newLocation.x) == 2 && Math.Abs(location.y - newLocation.y) == 1 ) || (Math.Abs(location.x - newLocation.x) == 1 && Math.Abs(location.y - newLocation.y) == 2) )
                return "true";
            else 
                return "false";
        }


        public override string toString()
        {
          return "?";

        }

    }
}

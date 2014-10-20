﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class King : Figure
    {
        public bool castable; 
        
        public King(Location baseLocation, Board board, Player player) : base(baseLocation, board,  player) {
            this.castable = true;
        }
        public override bool canBeMoved(Location newLocation)
        {
            if ((Math.Abs(location.x - newLocation.x) <= 1 && Math.Abs(location.y - newLocation.y) <= 1) && player.atRisk()==false)
                return true;
            else
                return false;
        }

        public override bool eatAt(Location targetLocation)
        {
            return false;
        }
        public override string toString()
        {
            return "K";

        }
    }
}
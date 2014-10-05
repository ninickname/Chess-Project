using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class Figure
    {

        public static bool UP = true; // will be used for the pawns and for the player constructor
        public static bool down = false;

        

        public Location location;
        public bool direction;
        public Board board;
        public Player player;


        public Figure() { }

        public Figure(Location baseLocation, bool direction, Board board, Player player) {

            this.location = baseLocation;
            this.direction = direction;
            this.board = board;
            this.player = player;
        }

        public abstract bool move(Location newLocation);
        

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public abstract class Figure
    {

        public const bool UP = true; // will be used for the pawns and for the player constructor
        public const bool DOWN = false;

        public Location location;
        public Board board;
        public Player player;


        public Figure() { }

        public Figure(Location baseLocation,  Board board, Player player)
        {
            this.location = baseLocation;
            this.board = board;
            this.player = player;
        }
        public Figure(Figure other)
        {
            this.location = other.location;
            this.board = other.board;
            this.player = other.player;
        }

        public void setLocation(Location newLocation)
        {
            location = newLocation;
        }

        public abstract bool canBeMoved(Location newLocation);
        /* this fucnction checks whether the figure can be moved to the new location or not , if the figure can be moved there  ,
         * than it should return true 
         * if the move is illigal for this kind of figure , there will rise illegal move exception ,
         * if the move is legal , 
         * but there is something standing in the way, or it cant be moved by anyother reason * check *
         * the function will return fasle 
         *
         * the input should be legal existing free space on the board , whitch exludes illigal places( out of the board) , and the location of any of the team , or enemy team figures .;
         * 
         */

        public abstract bool eatAt(Location targetLocation);


        public abstract string toString();


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Bishop:Figure
    {
        public Bishop(Figure other) : base(other) { }

        public Bishop(Location baseLocation, Board board, Player player) : base(baseLocation, board, player) { }



        public override string canEatAt(Location targetLocation)
        {
            return canBeMoved(targetLocation);

        }
        /*try to eat , checking if the move is legal */
        public override string canBeMoved(Location newLocation)
        {
            /* after some exp with the rook , the bishop was pretty straigt forward , check if the move is legal , 4 directions , and thats it . 
             
             */
            string Direction = "";

            if (Math.Abs(newLocation.x - location.x) == Math.Abs(newLocation.y - location.y)) // the the movment is legit, and there is other chacking and tunings to do.. 
            {
                if (newLocation.x - location.x > 0 && newLocation.y - location.y > 0)
                {
                    Direction = "UPRIHGT";
                }
                else if (newLocation.x - location.x < 0 && newLocation.y - location.y > 0)
                {
                    Direction = "UPLEFT";
                }

                else if (newLocation.x - location.x > 0 && newLocation.y - location.y < 0)
                    Direction = "DOWNRIGHT";
                else
                    Direction = "DOWNLEFT";

            }
            else
                return "the rook can move only vertically and horizontally ";

            switch (Direction)
            {
                case "UPRIHGT":
                    for (int i = 0; i < newLocation.x - location.x; i++)
                        if (board.isEmpty(new Location((char)(location.x + i), location.y + i)) == false)
                            return "false";
                    break;

                case "UPLEFT":

                    for (int i = 0; i < Math.Abs(newLocation.x - location.x); i++)
                        if (board.isEmpty(new Location((char)(location.x - i), location.y + i)) == false)
                            return "false";
                    break;
                case "DOWNRIGHT":
                    for (int i = 0; i < newLocation.y - location.y; i++)
                        if (board.isEmpty(new Location((char)(location.x + i), location.y - i)) == false)
                            return "false";

                    break;
                case "DOWNLEFT":
                    for (int i = 0; i < Math.Abs(newLocation.y - location.y); i++)
                        if (board.isEmpty(new Location((char)(location.x - i), location.y - i)) == false)
                            return "false";
                    break;

                default:
                    break;
            }
            return "true";


        }


        public override string toString()
        {
            return "B";

        }
    }
}

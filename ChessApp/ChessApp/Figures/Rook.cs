using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Rook : Figure
    {
        public bool castable; 
        
        public Rook(Figure other) : base(other) { }

        public Rook(Location baseLocation, Board board, Player player) : base(baseLocation, board,  player) {
            this.castable = true;
        }



        public override bool canBeMoved(Location newLocation)
        {
            /* this function returns if the figure can be moved to the specified location , 
             * if it can be it is moved and returns true
             * if the move is not legal throws illigal move execption
             * 
             * the location that the function expects to recieve is after a confurmation that this location is not occupied
             */

            /*the rook is much simplier , just a for loop to check if everything is clear and gg .//טעות של צעירים
             * 
             * wel not so gg after all , still have to follow whitch direction im moveing so i could iterate over the path . 
             * 
             * and for the next statment , as bibi said , הראשון לא נכון והשני לא יקרה 
             * no need to follow directions and no need to bcome big for the greater casuse . //טעות של צעירים
             * 
             * of course i wound this as a total lie trying to develop without directions .
             * */

            /*but i have to differ between movment in X or movment in Y
             * and not unly that , i need also to follow the negative and the positive by diifrents ways . 
             * 
             
             */
            string Direction;
            if (newLocation.x == location.x)
                if (newLocation.y > location.y)
                {
                    Direction = "UP";
                }
                else
                {
                    Direction = "DOWN";
                }
            else if (newLocation.y == location.y)
            {
                if (newLocation.x > location.x)
                    Direction = "RIGHT";
                else
                    Direction = "LEFT";
            }
            else return false;
           //throw new IllegalMoveExeption("the rook can move only vertically and horizontally ");

            switch (Direction)
            {
                case "UP":
                    for (int i = 0; i < newLocation.x - location.x; i++)
                        if (board.isEmpty(new Location((char)(location.x + i), location.y)) == false)
                            return false;
                    break;

                case "DOWN":

                    for (int i = 0; i < Math.Abs(newLocation.x - location.x); i++)
                        if (board.isEmpty(new Location((char)(location.x - i), location.y)) == false)
                            return false;
                    break;
                case "RIGHT":
                    for (int i = 0; i < newLocation.y - location.y; i++)
                        if (board.isEmpty(new Location(location.x, location.y + i)) == false)
                            return false;

                    break;
                case "LEFT":
                    for (int i = 0; i < Math.Abs(newLocation.y - location.y); i++)
                        if (board.isEmpty(new Location(location.x, location.y - i)) == false)
                            return false;
                    break;

                default:
                    break;
            }
            return true;
        }

        public override bool eatAt(Location targetLocation)
        {

            return canBeMoved(targetLocation);
        }

        public override string toString()
        {
            //if(player.direction== Figure.UP)
            /* legacy for no reasonble reason will be deleted soon */
               return "R";   

        }
    }
}

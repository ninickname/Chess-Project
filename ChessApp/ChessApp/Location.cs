using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Location
    {
        public static int END_OF_BOARD_TOP = 8;
        public static int END_OF_BOARD_BOTTON = 1;
        public static int END_OF_BOARD_LEFT = 'a';
        public static int END_OF_BOARD_RIGHT = 'h';


        public char x;
        public int y;

        public Location (char x, int y)
        {
            x = Char.ToLower(x);
            if( x > END_OF_BOARD_RIGHT || x < END_OF_BOARD_LEFT || y>END_OF_BOARD_TOP || y < END_OF_BOARD_BOTTON)
            {
                /// <exception cref="OutOfTheBoardException">the location is illigal.</exception>
                throw new OutOfTheBoardException();
            }
            else
            {
                setLocation(x, y);
            }
        }


        void setLocation(char x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(Object obj)
        {
            if (obj is Location)
                return this.GetHashCode() == obj.GetHashCode();        //x == ((Location)obj).x && y == ((Location)obj).y;
            else
                return false;
        }//this way or another this should work ... 


        public override int GetHashCode() {

            return this.x.GetHashCode() + this.y.GetHashCode(); 
     
        }



    }
}

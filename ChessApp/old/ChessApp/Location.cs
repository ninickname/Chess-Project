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
        
        
        public Location()
        {
        
        }
        public Location (char x, int y)
        {
            setLocation(x, y);
        }


        public string setLocation(char x, int y)
        {
            x = Char.ToLower(x);
            if (x > END_OF_BOARD_RIGHT || x < END_OF_BOARD_LEFT || y > END_OF_BOARD_TOP || y < END_OF_BOARD_BOTTON)
            {
                return "this location is illigal ";
            }
            else
            {
                this.x = x;
                this.y = y;

                return "true";
            }
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

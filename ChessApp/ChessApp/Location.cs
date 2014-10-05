using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Location
    {
        public char x;
        public int y;
    
        public Location(char x, int y)
        {
            setLocation(x, y);
        }


        void setLocation(char x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
     	     return base.Equals(obj);
        }





    }
}

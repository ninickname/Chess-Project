using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Location
    {
        char x;
        int y;

        Location(char x, int y)
        {
            setLocation(x, y);
        }

        void setLocation(char x, int y)
        {
            this.x = x;
            this.y = y;
        }





    }
}

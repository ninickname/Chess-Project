using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    abstract class Figure
    {
        public Location location;

        Figure(Location baseLocation) {

            this.location = baseLocation;
        }
        
        public Boolean Move(Location newLocation);
        

        
    }
}

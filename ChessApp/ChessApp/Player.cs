using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Player
    {
        public static bool UP = true;
        public static bool down = false;

        public List<Figure> figures;
        public bool direction;
            
        Player(bool direction){    
            this.figures = new List<Figure>();
            this.direction = direction;
        }

    }
    
}

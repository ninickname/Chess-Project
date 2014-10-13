using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Player
    {

        public List<Figure> figures;
        public bool direction;
            
        public Player(bool direction){    
            this.figures = new List<Figure>();
            this.direction = direction;
        }


        public Figure placeTaken(Location asked ) {

            foreach (Figure fig in figures) {
                // this if might not be working ! 
                // well it dont supposed to  , 
                if (fig.location.Equals (asked) ) {
                    return fig;
                }
            }
            return null;
        
        
        }

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*REMEMBER THAT THE LOCATION CONSTRUCTOR THROWS ECEPTION*/

            Board bbb = new Board();
            

            do
            {
                bbb.print();
                bbb.tryToMove(new Location('a', 2), new Location('a', 4));
                
                
                
                
                bbb.next();

                
                
                
                
                
                
                /**
                 * player got his turn
                 * 
                 * he trys and trys ,
                 * 
                 * 
                 * if he sucseeded to move . next()
                 */







                bbb.print();
                bbb.tryToMove(new Location('b', 2), new Location('b', 4));
            } while (true);
            

        }
    }
}

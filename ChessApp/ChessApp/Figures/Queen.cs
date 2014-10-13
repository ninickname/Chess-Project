using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp.Figures
{
    class Queen : Figure
    {
        public override bool canBeMoved(Location newLocation)
        {
            /* well here i try to be "smarter than im supposed to be" 
             * and trying to avoud the copy paste , that is not that nessesery at this location . 
             * my plan is to create a bishop and a rook with the same coordinates of the queen , check if they can be moved to a certain location , if one of the can VIOLA ! 
             * if non can , than just throw them away and return false , the only important thing is to follow exceptions that can fly here from corner to corner 
             */
            try
            {
                Rook rook = new Rook(this);

                if (rook.canBeMoved(newLocation))
                    return true;
            }

            catch (IllegalMoveExeption)
            {
                /*well this is illigal move for the rook , but will it be still illegal for the bishop?*/
                /*we will see it soon enough*/

            }
            catch (Exception)
            {
                Console.WriteLine("THERE IS UNKNOW EXCEPTION THAT FCKS YOUR PROGRAMA NOOB ! ");// makes it 'a' and prints it
            }
            try
            {
                Bishop bi = new Bishop(this);
                return bi.canBeMoved(newLocation);

            }
            catch (IllegalMoveExeption)
            {
                /*well this is hardcore , this means that this move is not legal for the bishop ither , which means that all im left to do is return false */

                return false;
            }
            catch (Exception)
            {
                Console.WriteLine("THERE IS UNKNOW EXCEPTION THAT FCKS YOUR PROGRAMA NOOB ! ");// makes it 'a' and prints it
            }


            Console.WriteLine("you should never see this message , and if you do refer to the quenn movemvent function . ");// makes it 'a' and prints it


            return false;
        }


        public override bool eatAt(Location targetLocation)
        {

            return false;

        }


    }
}

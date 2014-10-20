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
            Location from = new Location('a', 2);
            Location to = new Location('a', 2);
            Boolean next = false;
            string answer = "a";

            do
            {   /*turn starts , switch sides , cleaing screen and printing the new board */



                /*here is the output magic happends */
                bbb.next();
                Console.Clear();
                bbb.print();


                do/* a whole turn till the turn secseeds , his king is not in danger and */
                {
                    /*get input from user , create locations and "try to move "
                     *instead of getting the exeptions as i planned , i removed them and dont the whole talking with message passing and printing . 
                     *i had no choice beacuse ofthe value of running time for the ai.
                     */










                    /****************************************************************************************/


                    /* here is the input magic happedns */


                    /****************************************************************************************/









                    answer = bbb.tryToMove(from, to);

                    switch (answer)
                    {

                        case "true":
                            next = bbb.current.atRisk() == false;// here i already know the try to move returned true ; i recheck that the king is not at risk , and allow to pass the queue to the second player . 
                            break;
                        case "false":
                            continue;
                        default:
                            Console.WriteLine(answer);
                            break;
                    }

                } while (next);


            } while (true);// this is when the game ends 


        }
    }
}

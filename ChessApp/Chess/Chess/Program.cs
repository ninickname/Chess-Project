using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Program
    {
        public static bool SOURCE = true;
        public static bool DEST = false;
        static void Main(string[] args)
        {
            /*REMEMBER THAT THE LOCATION CONSTRUCTOR THROWS ECEPTION*/

            Board bbb = new Board();
            Move current= null;
            Move previous;
            Boolean next;
            Boolean white;

            string answer;

            do
            {
                bbb.print();
                white = bbb.White == bbb.current;
                next = false;

                do/* a whole turn till the turn succeed , king is not in danger and the input and the move was legal  */
                {
                    /*
                     * get input from user , create locations and "try to move "
                     * instead of getting the exeptions as i planned , i removed them and dont the whole talking with message passing and printing . 
                     * i had no choice beacuse ofthe value of running time for the ai.
                     */

                    Console.WriteLine("player " + (white ? "white" : "black ") + " turn");

                    //input
                    current = getInput();
                                 answer = bbb.tryToMove(current);
                    
                    // result 
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

                } while (!next);

                bbb.next();

                Console.Clear();

                /*turn ends , switch sides , cleaing screen and printing the updated  */

            } while (true);// this is when the game ends 
        }

        public static Move getInput( bool again = false)
        {

            Console.WriteLine("Please enter the move in the format of CN-CN " + (again ? "again !!" : ""));

            string input = Console.ReadLine();
            Move ret =new Move(); 
            bool passed = ret.setValues(input)=="true"; 
            
            if (!passed)
            {
                return getInput(true);
            }
            
            else
                return ret;



        }


        public static void debugPrint(string args)
        {
            Console.WriteLine("************DEBUGING pur·pose ONLY ***************");
            Console.WriteLine("************" +     args        + "***************");
            Console.WriteLine("************DEBUGING pur·pose ONLY ***************");


        }
    }

}

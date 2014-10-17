using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Board
    {
        public Player Black;
        public Player White;

        public Player current;
        public Player opponent;


        public Board()
        {
            this.Black = new Player(Figure.DOWN, this);
            this.White = new Player(Figure.UP, this);
            current = White;
            opponent = Black;
        }

        /*currently prinring a board , colored with the figures in place */
        public void print()
        {
            Figure temp;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("   a  b  c  d  e  f  g  h    ");
            for (int i = Location.END_OF_BOARD_TOP; i >= Location.END_OF_BOARD_BOTTON; i--)// from the first row to the last , top to bottom
            {
                Console.WriteLine("   _  _  _  _  _  _  _  _    ");

                Console.Write(i + " |");
                for (int j = Location.END_OF_BOARD_LEFT; j <= Location.END_OF_BOARD_RIGHT; j++)//from the first collomn to the last , left to right
                {
                    temp = figureAt(new Location((char)j, i));

                    if (temp == null)
                        Console.Write("  |");
                    else
                    {
                        if (temp.player.direction == Figure.UP) // whitch means the figure is WHITE 
                            Console.ForegroundColor = ConsoleColor.White;
                        else
                            Console.ForegroundColor = ConsoleColor.Black;

                        Console.Write(temp.toString());
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(" |");
                    }

                }//end of the first for     
                Console.WriteLine(i + " ");

            }//end of the second for 
            Console.WriteLine("   _  _  _  _  _  _  _  _    ");
            Console.WriteLine("   a  b  c  d  e  f  g  h    ");
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public bool isEmpty(Location loc)
        {
            //checks if the location is empty on the board
            return figureAt(loc) == null;
        }

        public Figure figureAt(Location asked)
        {
            foreach (Figure fig in current.figures.Concat(opponent.figures))
            {
                if (fig.location.Equals(asked))
                {
                    return fig;
                }
            }
            return null;
        }

        public Figure friendlyfigureAt(Location asked)
        {
            foreach (Figure fig in current.figures)
            {
                if (fig.location.Equals(asked))
                {
                    return fig;
                }
            }
            return null;
        }

        public Figure opponentfigureAt(Location asked)
        {
            foreach (Figure fig in opponent.figures)
            {
                if (fig.location.Equals(asked))
                {
                    return fig;
                }
            }
            return null;
        }
        public bool tryToMove(Location sourceLoc, Location targetLoc)
        {
            /*i expect to recive to legal locations and here i check the rest*/
            if (current.atRisk())
            {
                Console.WriteLine("be careful you king is at risk!");
            }


            Figure source = figureAt(sourceLoc);


            if (source == null)/*checking if there is a source at all */
            {
                throw new IllegalMoveExeption("there is no figure to move is that location ");
            }
            if (source.player != current) /*if you try to move your oppenents figure*/
            {
                Console.WriteLine("you retard you cant move figure of your enemy !");
                return false;
            }
            if (sourceLoc.Equals(targetLoc))/*if you try to move to your own location*/
            {
                Console.WriteLine("you retard you cant move the figure to her location and just waste your move like that ...");
                return false;
            }

            Figure target = figureAt(targetLoc);

            if (target == null)/*checking if there is a target */
            {
                return move(source, targetLoc);
            }
            else if (current == target.player)/* checking if the target belongs to the curret player*/
            {
                throw new IllegalMoveExeption("you cant eat your own figures!");
            }
            else
                return eat(source, targetLoc);
        }

        private bool eat(Figure source, Location targetLoc)
        {

            /*im getting here wehn i expect that the source is a figure of the playing player ,
             * and that the target loctaion contains enemy figure*/

            if (source.eatAt(targetLoc))
            {
                Figure target = figureAt(targetLoc);
                Location tempLoc = source.location;
                source.location = targetLoc;

                if (source.player.atRisk())
                {
                    source.location = tempLoc;
                    throw new WillCreateSelfCheck(" you are retard , your move will get yourking killed ! ");
                }
                opponent.figures.Remove(target);


                return true;
            }
            else return false;


        }

        private bool move(Figure source, Location targetLoc)
        {
            /*when i get here i expect that the figure is of the current player and that the target in empty*/

            if (source.canBeMoved(targetLoc))
            {
                Location tempLoc = source.location;
                source.location = targetLoc;

                if (source.player.atRisk())
                {
                    source.location = tempLoc;
                    throw new WillCreateSelfCheck(" you are retard , your move will get your king killed ! ");
                }
                return true;
            }
            else
                return false;
        }



        internal void next()
        {
            Player temp = current ;
            current = opponent;
            opponent = temp;
        }
    }
}

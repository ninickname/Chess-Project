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
        public Move currentMove;
        public Move previousMove;

        public Board()
        {
            this.Black = new Player(Figure.DOWN, this);
            this.White = new Player(Figure.UP, this);
            current = White;
            opponent = Black;
            currentMove = null;
            previousMove = null;
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

        public string tryToMove()
        {
            /*i expect to recive to legal locations and here i check the rest*/
            if (current.atRisk())
                Console.WriteLine("be careful you king is at risk!");

            Figure source = figureAt(currentMove.from);

            if (source == null)/*checking if there is a source at all */
                return "there is no figure to move is that location ";

            if (source.player != current) /*if you try to move your oppenents figure*/
                return "you retard you cant move figure of your enemy !";

            if (currentMove.from.Equals(currentMove.to))/*if you try to move to your own location*/
                return "you retard you cant move the figure to her location and just waste your move like that ...";

            Figure target = figureAt(currentMove.to);

            if (target == null)/*checking if there is a target */
                return moveOReat(source, currentMove.to);

            else if (current == target.player)/* checking if the target belongs to the curret player*/
                return "you cant eat your own figures!";

            else
                return moveOReat(source, currentMove.to, "eat", target);
        }

        private string moveOReat(Figure source, Location targetLoc , string moveOReat = "move" , Figure target = null)
        {

            /*im getting here wehn i expect that the source is a figure of the playing player ,
             * and that the target loctaion contains enemy figure*/

            string answ =( moveOReat == "move") ? source.canBeMoved(targetLoc) : source.canEatAt(targetLoc);
            if ( answ == "true")
            {
                Location tempLoc = source.location;
                Figure tempfig = figureAt(targetLoc);

                source.moveTo(targetLoc);

                if (current.atRisk())
                {
                    source.setLocation(tempLoc);
                    opponent.figures.Add(tempfig);

                    return " you are retard , your move will get your king killed ! ";
                }
                if (moveOReat == "eat")
                    opponent.figures.Remove(target);

                return "true";
            }
            else 
                return answ;

        }

        internal void next()
        {
            Player temp = current;
            current = opponent;
            opponent = temp;
        }
    }
}

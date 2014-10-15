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
        public List<Figure> figures;

        public Board()
        {
            this.figures = new List<Figure>();

            this.Black = new Player(Figure.DOWN, this);
            this.White = new Player(Figure.UP, this);
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
                Console.WriteLine(i+" ");

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
            foreach (Figure fig in figures)
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
            Figure source = figureAt(sourceLoc);

            if (source == null)
            {
                throw new IllegalMoveExeption("there is no figure to move is that location ");
            }

            Figure target = figureAt(targetLoc);

            if (target == null)
            {
                return move(source, targetLoc);
            }
            else if (source.player == target.player)
            {
                throw new IllegalMoveExeption("you cant eat your own figures!");
            }
            else
                return eat(source, targetLoc);



        }

        private bool eat(Figure source, Location targetLoc)
        {
            if (source.eatAt(targetLoc))
            {
                source.location = targetLoc;
                this.figures.Remove(figureAt(targetLoc));
                return true;
            }
            else return false;
        
            
        }

        private bool move(Figure source, Location targetLoc)
        {
            if (source.canBeMoved(targetLoc))
            {
                source.location = targetLoc;
                return true;
            }
            else return false;
        }


    }
}

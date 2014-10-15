using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChessApp
{
    public class Player
    {

        public bool direction;
        public Board board;

        public Player(bool direction, Board board)
        {
            this.direction = direction;

            int y, d;
            if (direction == Figure.UP)
            {
                y = Location.END_OF_BOARD_BOTTON;
                d = +1;
            }
            else
            {
                y = Location.END_OF_BOARD_TOP;
                d = -1;
            }


            board.figures.Add(new Rook  (new Location((char)Location.END_OF_BOARD_LEFT  , y), board, this));
            board.figures.Add(new Rook  (new Location((char)Location.END_OF_BOARD_RIGHT , y), board, this));

            board.figures.Add(new Bishop(new Location((char)(Location.END_OF_BOARD_LEFT + 2), y), board, this));
            board.figures.Add(new Bishop(new Location((char)(Location.END_OF_BOARD_RIGHT - 2), y), board, this));

            board.figures.Add(new Knight(new Location((char)(Location.END_OF_BOARD_LEFT + 1), y), board, this));
            board.figures.Add(new Knight(new Location((char)(Location.END_OF_BOARD_RIGHT - 1), y), board, this));

            board.figures.Add(new Queen (new Location((char)(Location.END_OF_BOARD_RIGHT - 4), y), board, this));

            board.figures.Add(new King  (new Location((char)(Location.END_OF_BOARD_RIGHT - 3), y), board, this));


            for (int i = Location.END_OF_BOARD_LEFT; i <= Location.END_OF_BOARD_RIGHT; i++)
            {
                board.figures.Add(new Pawn(new Location((char)i, y + d), direction, board, this));
            }
        }




        public bool atRisk(Location loc)
        {
            foreach (Figure item in board.figures)
            {
                if (item.player != this && item.canBeMoved(loc))// not the same player and also the figure can be moved to the new location, so the king is at risk
                        return true;
                }

            return false;
        }
    }

}

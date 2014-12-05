using System;

namespace ChessApp
{
    public class PawnGrewUp : Exception
    {
        public PawnGrewUp()
        {
        }

        public PawnGrewUp(string message)
            : base(message)
        {
        }

        public PawnGrewUp(string message, Exception inner)
            : base(message, inner)
        {
        }

        public PawnGrewUp(Figure pawn)
            : base()
        {
        }


    }
}
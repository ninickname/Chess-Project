using System;

namespace ChessApp
{
    public class IllegalMoveExeption : Exception
    {
        public IllegalMoveExeption()
        {
        }

        public IllegalMoveExeption(string message)
            : base(message)
        {
        }

        public IllegalMoveExeption(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
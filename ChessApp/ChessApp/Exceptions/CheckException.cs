using System;

namespace ChessApp
{
    public class CheckExeption: Exception
    {
        public CheckExeption()
        {
        }

        public CheckExeption(string message)
            : base(message)
        {
        }

        public CheckExeption(string message, Exception inner)
            : base(message, inner)
        {
        }

        public CheckExeption(Figure pawn)
            : base()
        {
        }


    }
}
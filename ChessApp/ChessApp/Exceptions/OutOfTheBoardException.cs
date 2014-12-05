using System;

namespace ChessApp
{
    public class OutOfTheBoardException : Exception
    {
        public OutOfTheBoardException()
        {
        }

        public OutOfTheBoardException(string message)
            : base(message)
        {
        }

        public OutOfTheBoardException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
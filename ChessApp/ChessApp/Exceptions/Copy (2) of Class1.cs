using System;



namespace ChessApp
{
    public class message : Exception
    {
        public message()
        {
        }

        public message(string message)
            : base(message)
        {
        }

        public message(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
using System;


namespace ChessApp
{
    public class Concepts : Exception
    {
        public Concepts()
        {
        }

        public Concepts(string message)
            : base(message)
        {
        }

        public Concepts(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
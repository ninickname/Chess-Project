using System;

namespace ChessApp
{
    public class WillCreateSelfCheck : Exception
    {
        public WillCreateSelfCheck()
        {
        }

        public WillCreateSelfCheck(string message)
            : base(message)
        {
        }

        public WillCreateSelfCheck(string message, Exception inner)
            : base(message, inner)
        {
        }

        public WillCreateSelfCheck(Figure pawn)
            : base()
        {
        }


    }
}
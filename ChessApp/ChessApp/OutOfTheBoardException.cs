using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class OutOfTheBoardException : System.ApplicationException
    {

        //taken and edited from microsofs MSDN
        public OutOfTheBoardException() { }
        public OutOfTheBoardException(string message) { }
        public OutOfTheBoardException(string message, System.Exception inner) { }


        //currently this is less relevant but ill leave it here for future development 



        // Constructor needed for serialization 
        // when exception propagates from a remoting server to the client.
        protected OutOfTheBoardException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { }
    }
}

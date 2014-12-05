using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public class Move
    {
        public Location from;
        public Location to;

        public Move() { }
        public Move(string input)
        {
            setValues(input);
        }

        public string setValues(string input)
        {
            from = new Location();
            to = new Location();
            bool pass1, pass2;
            pass1 = from.setLocation(input[0], input[1]-'0') == "true";
            pass2 = to  .setLocation(input[3], input[4]-'0') == "true";
            return (pass1 && pass2 )? "true" : "false";

        }
    }
}

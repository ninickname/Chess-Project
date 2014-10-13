using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", 'c' == 'b' + 1);
            /*REMEMBER THAT THE LOCATION CONSTRUCTOR THROWS ECEPTION*/
            Location a = new Location('A',3);
            Location b = new Location('a', 6);
            Console.WriteLine("{0}", a.Equals(b) );//true
            Console.WriteLine("{0}", a == (b));//false

            Console.WriteLine( Char.ToLower('A'));// makes it 'a' and prints it

            Console.WriteLine( (char)('a'+1));// makes it 'a' and prints it

            char c = '\u2655'; 
            Console.WriteLine(c);// makes it 'a' and prints it
            Console.WriteLine(Char.ToLower('A'));// makes it 'a' and prints it
            Console.WriteLine(Char.ToLower('A'));// makes it 'a' and prints it

        }
    }
}

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
            Location a=new Location('a',19);

        }
    }
}

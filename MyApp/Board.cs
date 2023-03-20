using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Board
    {
        public static void DrawBoard(char[] position)
        {
            Console.WriteLine(" _____ _____ _____ ");
            Console.WriteLine("|     |     |     | ");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", position[1], position[2], position[3]);
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", position[4], position[5], position[6]);
            Console.WriteLine("|_____|_____|_____| ");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|  {0}  |  {1}  |  {2}  |", position[7], position[8], position[9]);
            Console.WriteLine("|_____|_____|_____| ");
        }
    }
}
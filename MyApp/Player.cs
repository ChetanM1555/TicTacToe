using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Player
    {
        public static char[] choice(char[] pos, char xo)
        {
            bool correct = false;
            do{
            Console.Write("Enter a digit between 1 and 9: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (char.IsDigit(keyInfo.KeyChar))
            {
                int digit = int.Parse(keyInfo.KeyChar.ToString());
                char charValue = (char)(digit + '0');
                int index = Array.IndexOf(pos, charValue);
                                Console.WriteLine(index);
                if (index >= 0)
                {
                    Console.WriteLine("You entered: " + digit);
                    pos[digit] = xo;
                    correct = true;
                }
                else 
                {
                    Console.WriteLine("That position was already picked");
                }

            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a digit between 1 and 9.");
            }
            }while (correct == false);
            return pos;
        }

        public static bool winCondition(char[] pos)
        {
            if (pos[1]==pos[2]&&pos[2]==pos[3]) {
                return true;
            }
            if (pos[4]==pos[5]&&pos[5]==pos[6]) {
                return true;
            }
            if (pos[7]==pos[8]&&pos[8]==pos[9]) {
                return true;
            }
            if (pos[1]==pos[4]&&pos[4]==pos[7]) {
                return true;
            }
            if (pos[2]==pos[5]&&pos[5]==pos[8]) {
                return true;
            }
            if (pos[3]==pos[6]&&pos[6]==pos[9]) {
                return true;
            }
            if (pos[1]==pos[5]&&pos[5]==pos[9]) {
                return true;
            }
            if (pos[7]==pos[5]&&pos[5]==pos[3]) {
                return true;
            }
            return false;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Player
    {
        public static char[] choice(char[] pos, char xo){
            bool correct = false;
            do{
            Console.Write("Enter a digit between 1 and 9: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            int digit = int.Parse(keyInfo.KeyChar.ToString());
            char charValue = Convert.ToChar(digit);
            Console.WriteLine();
            // if (char.IsDigit(keyInfo.KeyChar) && diget != 0)
            // {
                
                int index = Array.IndexOf(pos, charValue);

                if (index <= 0)
                {
                    
                    Console.WriteLine("You entered: " + digit + index);
                    pos[digit] = xo;
                    correct = true;

                }
                else {
                    Console.WriteLine("That position was already picked");
                    
                }
                
            // }
            // else
            // {
            //     Console.WriteLine("Invalid input. Please enter a digit between 1 and 9.");
            // }
            }while (correct == false);
            return pos;
        }
    }
}
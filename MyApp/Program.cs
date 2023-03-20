// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static MyApp.Board;
using static MyApp.Player;

class Program
{
static int player = 1;
static char[] position = { '0', '1', 'X', '3', '4', '5', '6', '7', '8', '9' };
static char[] xo = {'X','O'};
static bool win = false;

public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!!");
        Console.WriteLine("Player1 is X and Player2 is O...");
        char place = 'X';
        do{
            if (player%2 != 0)
            {
                place = 'X';
                
            }
            else{
                place ='O';
            }
            Console.WriteLine(place);
            DrawBoard(position);
            position = choice(position, place);
            player++;
            // win = true;
        }while(win == false);
    }
}



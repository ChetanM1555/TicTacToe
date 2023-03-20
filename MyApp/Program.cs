// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using static MyApp.Board;
using static MyApp.Player;

class Program
{
static int player = 1;
static char[] position = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
static char[] xo = {'X','O'};
static bool win = false;


public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!!");
        Console.WriteLine("Player1 is X and Player2 is O...");
        char place = 'X';
        DrawBoard(position);
        do{
            
            if (player%2 != 0)
            {
                place = 'X';
            }
            else{
                place ='O';
            }
            Console.WriteLine(place);
            position = choice(position, place);
            DrawBoard(position);
            player++;
            win = winCondition(position);
            // win = true;
        }while(win == false && player != 10);
            if (win == true){
                Console.WriteLine("Congrates "+place+"'s wins!!");
            }
            else{
                Console.WriteLine("Out of plays, the game is a draw!!");

            }
    }
}



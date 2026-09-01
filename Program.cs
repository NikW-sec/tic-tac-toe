string[] grid =
  {
    "0", "1", "2",
    "3", "4", "5",
    "6", "7", "8"
  };


void displayGrid() //display the current gird 
{
  //to display grid
  Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
  Console.WriteLine();
}


int turning = 0;  // used to decide if it is palyer 1 or 2 turn, use even or odd caluculation
string currentPlayer = null;  //use for who actual place a move later
bool ended = false;
void turn()
{
 while (ended = false)
  { 
    if (turning % 2 ==0)
     {
        Console.WriteLine("It is player 1's turn");
        currentPlayer = "Player1";
     }
    else
     {
        Console.WriteLine("It is player 2's turn");
        currentPlayer = "Player2"; 
     }
    turning ++;
  }
}


void gridReplacement(int gridnumber)
{
 string symbol = null; // use to track if it is X or O
 if (currentPlayer == "Player1")
    {
      symbol = "X"; //player1 use x
    }
 else
    {
        symbol = "O"; //player2 use o
    }
 grid[gridnumber] = symbol;


 
}
    



static void main()
{
 //inital welcomign and user name
 Console.WriteLine("Welcome to tic tac toe");

 Console.WriteLine("Enter the name of player 1");
 string player1 = Console.ReadLine();
 Console.WriteLine("Enter the name of player 2");
 string player2 = Console.ReadLine();
}

int player1Score = 0;
int player2Score = 0;

string CurrentPlayerAndScore()
{
 if (currentPlayer == "Player1")
 {
  return $"Current player: {currentPlayer}, score {player1Score}";
 }
 else
 {
  return $"Current player: {currentPlayer}, score {player2Score}"; 
 }
}


main();
displayGrid();
currentPlayer = "Player1";
gridReplacement(1);
displayGrid();
Console.WriteLine(CurrentPlayerAndScore());


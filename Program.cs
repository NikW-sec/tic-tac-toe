using System.Security.Authentication.ExtendedProtection;

string player1Name = "";
string player2Name = "";
int player1Score = 0;
int player2Score = 0;
void inital()
{
 //inital welcomign and user name
 Console.WriteLine("Welcome to tic tac toe");

 Console.WriteLine("Enter the name of player 1");
 string player1 = Console.ReadLine();
 Console.WriteLine("Enter the name of player 2");
 string player2 = Console.ReadLine();
 player1Name = player1;
 player2Name = player2;
}

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
string currentPlayer = "Player1";  //use for who actual place a move later
string turn()
{
    if (turning % 2 ==0)
     {
        currentPlayer = "Player1";
        return"It is player 1's turn";
     }
    else
     {
        currentPlayer = "Player2"; 
        return"It is player 2's turn";
     }
    turning ++;
}


void gridReplacement(int gridnumber)
{
 string symbol = ""; // use to track if it is X or O
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



bool rematchAndScore(string result)
{
    if (result == "Player1Win")
    {
        player1Score++;
        Console.WriteLine(
            $"Congratulations {player1Name}, you won!");
    }
    else if (result == "Player2Win")
    {
        player2Score++;
        Console.WriteLine(
            $"Congratulations {player2Name}, you won!");
    }
    else if (result == "Draw")
    {
        Console.WriteLine("The game is a draw.");
    }
    else
    {
        Console.WriteLine("The game has not ended.");
        return true;
    }

    Console.WriteLine();
    Console.WriteLine($"{player1Name} score: {player1Score}");
    Console.WriteLine($"{player2Name} score: {player2Score}");
    Console.WriteLine();

    while (true)
    {
        Console.Write("Do you want a rematch? Enter yes or no: ");

        string answer =
            (Console.ReadLine() ?? "").Trim().ToLower();

        if (answer == "yes")
        {
            resetGrid();
            return true;
        }

        if (answer == "no")
        {
            Console.WriteLine("Goodbye");
            return false;
        }

        Console.WriteLine("Please enter 'yes' or 'no'.");
    }
}





void main()
{
 inital();
 displayGrid();
 CurrentPlayerAndScore();
 Console.WriteLine(turn());
 playerChoice();  //function in the logic branch, not here yet
 gridReplacement();
 checkResult(); //function in the logic branch, chekc win loss draw etc
 //if someone win:
 //rematchAndScore();

}

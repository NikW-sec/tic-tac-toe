string player1Name = "";
string player2Name = "";
int player1Score = 0;
int player2Score = 0;




void inital()
{
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

void displayGrid()
{
    Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
    Console.WriteLine();
}

void resetGrid()
{
    for (int i = 0; i <= 8; i++)
    {
        grid[i] = i.ToString();
    }
}

int turning = 0;
string currentPlayer = "Player1";

string turn()
{
    string message;
    if (turning % 2 == 0)
    {
        currentPlayer = "Player1";
        message = "It is player 1's turn";
    }
    else
    {
        currentPlayer = "Player2";
        message = "It is player 2's turn";
    }
    turning++;
    return message;
}

void gridReplacement(int gridnumber)
{
    string symbol;
    if (currentPlayer == "Player1")
    {
        symbol = "X";
    }
    else
    {
        symbol = "O";
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

bool rematchAndScore(string winner)
{
    Console.WriteLine($"{winner} won");
    Console.WriteLine();
    Console.WriteLine($"{player1Name}  score: {player1Score}");
    Console.WriteLine($"{player2Name}  score: {player2Score}");
    Console.WriteLine();
    Console.WriteLine("Do you want to rematch?");
    string rematch = Console.ReadLine();
    while (rematch != "yes" && rematch != "no")
    {
        Console.WriteLine("Please enter 'yes' or 'no'");
        Console.WriteLine("Do you want to rematch?");
        rematch = Console.ReadLine();
    }
    if (rematch == "yes")
    {
        resetGrid();
        turning = 0;
        return true;
    }
    else
    {
        Console.WriteLine("Goodbye");
        return false;
    }
}


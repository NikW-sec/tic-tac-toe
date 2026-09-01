//the two players' name and score
string player1Name = "";
string player2Name = "";
int player1Score = 0;
int player2Score = 0;




void inital() //ask for names
{
    Console.WriteLine("Welcome to tic tac toe");
    Console.WriteLine("Enter the name of player 1");
    string player1 = Console.ReadLine();
    Console.WriteLine("Enter the name of player 2");
    string player2 = Console.ReadLine();
    player1Name = player1;
    player2Name = player2;
}

string[] grid = //the grid
{
    "0", "1", "2",
    "3", "4", "5",
    "6", "7", "8"
};

void displayGrid() //show the current grid
{
    Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
    Console.WriteLine("---------");
    Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
    Console.WriteLine(); //better spacing
}

void resetGrid()
{
    for (int i = 0; i <= 8; i++)
    {
        grid[i] = i.ToString(); //rest the grid to default
    }
}

int turning = 0; //value used to keep track of the turn
string currentPlayer = "Player1";  //the player that is placing a move

string turn()
{
    string message;
    if (turning % 2 == 0) //player1's turn if it is even
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
    grid[gridnumber] = symbol; //replace that square with the player's symbol
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

bool rematchAndScore(string winner) //return true or false to see if the game should continue
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
        turning = 0; //rest the player turn
        return true;
    }
    else
    {
        Console.WriteLine("Goodbye");
        return false;
    }
}

int playerChoice()
{
    while (true)
    {
        Console.Write($"{currentPlayer}, choose a square: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 8 && grid[number] != "X" && grid[number] != "O")
        {
            return number;
        }
        Console.WriteLine("invalid square/taken");
    }
}

string checkResult()
{
    int[,] winPatterns =
    {
        {0,1,2}, {3,4,5}, {6,7,8}, // row
        {0,3,6}, {1,4,7}, {2,5,8}, // column
        {0,4,8}, {2,4,6}           // diagonal
    };

    for (int i = 0; i < 8; i++)
    {
        int a = winPatterns[i, 0];
        int b = winPatterns[i, 1];
        int c = winPatterns[i, 2];

        if (grid[a] == grid[b] && grid[b] == grid[c])
        {
            if (grid[a] == "X")
            {
                return "player 1 wins";
            }
            else if (grid[a] == "O")
            {
                return "player 2 wins";
            }
        }
    }

    bool full = true;
    foreach (string item in grid)
    {
        if (item != "X" && item != "O")
        {
            full = false;
            break;
        }
    }
    if (full)
    {
        return "draw";
    }
    return "game ongoing";
}

void main()
{
    inital();
    bool playing = true;

    while (playing)
    {
        displayGrid();
        Console.WriteLine(turn());
        Console.WriteLine(CurrentPlayerAndScore());

        int choice = playerChoice();
        gridReplacement(choice);

        string result = checkResult();

        if (result == "player 1 wins")
        {
            player1Score++;
            displayGrid();
            playing = rematchAndScore(player1Name);
        }
        else if (result == "player 2 wins")
        {
            player2Score++;
            displayGrid();
            playing = rematchAndScore(player2Name);
        }
        else if (result == "draw")
        {
            displayGrid();
            Console.WriteLine("It's a draw!");
            playing = rematchAndScore("nobody");
        }
        
    }
}

main();

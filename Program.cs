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

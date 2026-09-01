static int playerChoice()
{
    while (true)
    {
        Console.Write($"{currentPlayer}, choose a square: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 0 && number <= 8)
        {
            return number;
        }
    }
}




string checkResult()
{
    int[,] winPatterns =
    {
        {0,1,2}, {3,4,5}, {6,7,8}, // row
        {0,3,6}, {1,4,7}, {2,5,8}, // column
        {0,4,8}, {2,4,6}          // diagonal
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
                return "Player1Win";
            }
            else if (grid[a] == "O")
            {
                return "Player2Win";
            }
        }
    }
}

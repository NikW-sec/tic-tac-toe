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

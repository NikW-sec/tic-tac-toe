static int playerChoice()
{
    while (true)
    {
        Console.Write("choose a square: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 1 && number <= 9)
        {
            return number;
        }
    }
}

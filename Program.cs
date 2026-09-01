static void Players(string name1, string name2) //set up two players and their name (name using input later)
{
  string player1 = name1;
  string player2 = name2;
}  



static void TheGrid() //function for gird
{
 string[] grid =
  {
    "1", "2", "3",
    "4", "5", "6",
    "7", "8", "9"
  };

  Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
}

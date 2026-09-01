static void Players(string name1, string name2) //set up two players and their name (name using input later)
{
  string player1 = name1;
  string player2 = name2;
  int player1Score = 0;
  int player2Score = 0;
  Console.WriteLine(player1);
}  



static void TheGrid() //function for gird
{
 string[] grid =
  {
    "1", "2", "3",
    "4", "5", "6",
    "7", "8", "9"
  };
  //to display grid
  Console.WriteLine($"{grid[0]} | {grid[1]} | {grid[2]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[3]} | {grid[4]} | {grid[5]}");
  Console.WriteLine("---------");
  Console.WriteLine($"{grid[6]} | {grid[7]} | {grid[8]}");
}


//inital welcomign and user name
Console.WriteLine("Welcome to tic tac toe");

Console.WriteLine("Enter the name of player 1");
string user1 = Console.ReadLine();
Console.WriteLine("Enter the name of player 2");
string user2 = Console.ReadLine();

Players(user1,user2);

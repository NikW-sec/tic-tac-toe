# Tic-Tac-Toe

A two-player console Tic-Tac-Toe game built collaboratively in C#.

This was our first project using C#. We mainly had experience with Python, so this project helped us learn C# syntax, arrays, functions, loops, conditionals and user input.

## Features

- Two-player local game
- Custom player names
- Numbered grid from 0 to 8
- Alternating X and O turns
- Invalid and occupied-square detection
- Win and draw detection
- Score tracking
- Rematch option

## Collaboration

We divided the project into interface and game-logic branches.

### NikW-sec — Game interface

Worked on:

- Player names and scores
- `inital()` — welcomes the players and asks for their names
- `displayGrid()` — displays the current board
- `resetGrid()` — resets the board for a rematch
- `turn()` — alternates between the two players
- `gridReplacement()` — places X or O on the board
- `CurrentPlayerAndScore()` — displays the current player and score
- `rematchAndScore()` — displays results, tracks scores and handles rematches

### joshlam67 — Game logic

Worked on:

- `playerChoice()` — receives and validates the selected square
- `checkResult()` — checks for wins, draws and an ongoing game
- The main game loop that connects the interface and logic

## How to play

The squares are numbered like this:

```text
0 | 1 | 2
---------
3 | 4 | 5
---------
6 | 7 | 8
```

Player 1 uses `X` and Player 2 uses `O`.

On each turn, enter the number of an available square.

## Running the project

You need the .NET SDK installed.

```powershell
git clone https://github.com/NikW-sec/tic-tac-toe.git
cd tic-tac-toe
dotnet run
```

## GitHub workflow

We used GitHub to collaborate through:

- Separate `game-interface` and `game-logic` branches
- Commits and pushes
- Pull requests
- Merge-conflict resolution
- Testing with `dotnet build` and `dotnet run`
- A final merge into the `main` branch

## What we learned

- Basic C# syntax
- Arrays and two-dimensional arrays
- Functions and return values
- Loops and conditional statements
- Reading and validating console input
- Git branches, commits and pushes
- Pull requests and merging code
- Collaborating on one shared project

## Contributors

- [NikW-sec](https://github.com/NikW-sec) — game interface
- [joshlam67](https://github.com/joshlam67) — game logic

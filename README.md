
# Minesweeper

Minesweeper is a simple game created in c# as a console application.


## Design

•	The Minesweeper game is organized into several classes, each  responsible for a specific aspect of the game, adhering to SOLID principles.

•	The game loop is encapsulated in the MinesweeperGame class, which handles user interactions and game flow.

•	Input is managed by the InputManager class to ensure valid user input.

•	The MinefieldInitializer class manages the grid operations, Initializing Mine field and mine placement.

•	The MinefieldPrinter class displays the minefield, and the MinefieldExplainer class determines if a square contains a mine.

•	The MinefieldAnalyzer class recursively uncovers squares with no adjacent mines, Count Adjacent Mines and verifies win conditions.

•	Unit tests are provided to cover various functionalities using the NUnit framework.

## Assumptions

•	The game is played via a console interface.

•	The grid size is limited to a maximum of 10x10 for simplicity.

•	The user provides valid input within the specified range.

•	Number of mines should be 35% of the grid.

## Environment

•	Windows operating system.

•	.NET Framework or .NET Core runtime installed (version 6.0 or later).

## Steps

1.	Open Visual Studio or your preferred C# development environment.
2.	Open and Run the project 
3.	Run the unit tests using the testing framework's tools to ensure correctness.
4.	Compile and build the Minesweeper application.
5.	Run the compiled application from the command prompt or terminal.
6.	Follow the on-screen instructions to play the Minesweeper game.


## Authors

- [Anuja Jayathilaka](https://www.linkedin.com/in/anujachirantha/)


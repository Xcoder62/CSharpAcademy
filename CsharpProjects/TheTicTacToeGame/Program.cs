// See https://aka.ms/new-console-template for more information
using TheTicTacToeGame;

Console.WriteLine("Hello, World!");
Console.WriteLine("This Tic-Tac-Toe Game follows a numpad format (7 represents the top left square)");

// Create Two Players
Player player1 = new Player("X");
Player player2 = new Player("O");

// Create Tic-Tac-Toe Board
Board board = new Board();

Player currentPlayer = null;

Random rand = new Random();
var firstPlayer = rand.Next(0,2);

// Randomly select who gets to go first.
currentPlayer = firstPlayer == 0 ? player1 : player2;

// Start Game Loop
bool keepPlaying = true;
while (keepPlaying)
{
    System.Console.WriteLine($"It is {currentPlayer.PlayerName}'s turn.");
    board.DisplayBoard();
    currentPlayer.MakeChoice();
    
    while (!board.ConfirmChoice(currentPlayer))
    {
        currentPlayer.MakeChoice();
    }
    if (board.WinCondition())
    {
        board.DisplayBoard();
        System.Console.WriteLine($"Player {board.GetWinnerName()} has won the game!");
        keepPlaying = false;
    }
    currentPlayer = currentPlayer.PlayerName == "X" ? player2 : player1;
}

// Pause before ending program
Console.ReadLine();

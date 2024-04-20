using System;

class TicTacToe
{
    public char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }; // Represents the game board
    public char currentPlayer = 'X'; // 'X' starts the game

    public void MakeMove(int position)
    {
        if (position >= 0 && position < 9 && board[position] == ' ')
        {
            board[position] = currentPlayer;
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }

    public bool CheckWin()
    {
        // Check rows, columns, and diagonals for a win
        return (CheckLine(0, 1, 2) || CheckLine(3, 4, 5) || CheckLine(6, 7, 8) || // Rows
                CheckLine(0, 3, 6) || CheckLine(1, 4, 7) || CheckLine(2, 5, 8) || // Columns
                CheckLine(0, 4, 8) || CheckLine(2, 4, 6)); // Diagonals
    }


    public bool CheckLine(int cell1, int cell2, int cell3)
    {
        return board[cell1] != ' ' && board[cell1] == board[cell2] && board[cell2] == board[cell3];
    }

    public void DisplayBoard()
    {
        Console.WriteLine($"""
            ╔═══╦═══╦═══╗
            ║ {board[0]} ║ {board[1]} ║ {board[2]} ║
            ╠═══╬═══╬═══╣
            ║ {board[3]} ║ {board[4]} ║ {board[5]} ║
            ╠═══╬═══╬═══╣
            ║ {board[6]} ║ {board[7]} ║ {board[8]} ║
            ╚═══╩═══╩═══╝
        """);
    }
}


class Program
{
    static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();  // Creates an instance of the TicTacToe class
        while (!game.CheckWin())
        {
            Console.Clear();
            game.DisplayBoard();
            System.Console.WriteLine($"Player  {game.currentPlayer}, Enter your move using 0 through 8");
            int position = int.Parse(System.Console.ReadLine());
            
            game.MakeMove(position);

            
        }
        game.DisplayBoard();  // Call the DisplayBoard method to print the board
        if (game.CheckWin())
        {
            System.Console.WriteLine($"Player  {game.currentPlayer} wins!");
            
        }
        else
        {
            System.Console.WriteLine("Draw.");
        }
    }
}











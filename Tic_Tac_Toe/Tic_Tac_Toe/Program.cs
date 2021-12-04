using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Game");
            TicTacToeGame game = new TicTacToeGame();
            game.CreateGameBoard();
            game.PlayerInput();
        }
    }
}

using System;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Create Game Board, 2-Player Input, 3-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                TicTacToeGame game = new TicTacToeGame();
                switch (choice)
                {
                    case 1:
                        game.CreateGameBoard();
                        break;
                    case 2:
                        game.PlayerInput();
                        Console.WriteLine("Player Position is:" + game.PlayerInput());
                        break;
                    default:
                         flag = false;
                        break;
                }
            }
        }
    }
}
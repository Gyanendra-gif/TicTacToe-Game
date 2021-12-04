using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe
{
    public class TicTacToeGame
    {
        public char[] gameBoard = new char[10];
        public void CreateGameBoard()
        {
            for (int i = 1; i < gameBoard.Length; i++)
            {
                gameBoard[i] = ' ';
            }
        }
        public Char PlayerInput()
        {
            Console.WriteLine("Enter Your Input to Play the Game Between X/Y");
            char playerInput = Convert.ToChar(Console.ReadLine());
            char input = char.ToUpper(playerInput);
            if (input == 'X')
            {
                return playerInput;
            }
            if (input == 'O')
            {
                return playerInput;
            }
            return 'W';
        }
        public void Display()
        {
            Console.WriteLine("   |     |       |");
            Console.WriteLine("  {0}    |  {1}  |  {2}", gameBoard[1], gameBoard[2], gameBoard[3]);
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|________");
            Console.WriteLine("  {0}    |  {1}  |  {2}", gameBoard[4], gameBoard[5], gameBoard[6]);
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
            Console.WriteLine("___|_____|____________");
            Console.WriteLine("  {0}    |  {1}  |  {2}", gameBoard[7], gameBoard[8], gameBoard[9]);
            Console.WriteLine("   |     |    ");
            Console.WriteLine("   |     |    ");
        }
    }
}
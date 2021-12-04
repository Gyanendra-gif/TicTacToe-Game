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
    }
}
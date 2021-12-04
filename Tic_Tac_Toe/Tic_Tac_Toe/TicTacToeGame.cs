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
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayWithAI.Models
{
    public class TicTacToeGameState
    {
        /**
         * Represents the TicTacToe game board.
         * 0 - unmarked cell
         * 1 - marked by X
         * 2 - marked by O
         */
        public int[,] gameBoard;
        public int size;
        public bool isXsTurn;
        public const int MARKER_X = 1;
        public const int MARKER_O = 2;

        public TicTacToeGameState(int size, bool isXsTurn)
        {
            gameBoard = new int[size, size];
            this.isXsTurn = isXsTurn;
            this.size = size;
        }

        public void addMove(int row, int col)
        {
            if (isXsTurn)
            {
                gameBoard[row, col] = MARKER_X;
            }
            else
            {
                gameBoard[row, col] = MARKER_O;
            }

            changeTurn();
        }

        public void changeTurn()
        {
            isXsTurn = !isXsTurn;
        }

        public void computeNextMove()
        {

        }
    }
}
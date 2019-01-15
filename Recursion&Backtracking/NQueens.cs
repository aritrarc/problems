using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //Find the nth Fibonnaci Number
    public class NQueens
    {
        private int size = 10;
        void PrintSolution(int[,] board)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" " + board[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }

        //Only check left of current column. No need to check to the right
        Boolean isSafe(int[,] board, int row, int col)
        {
            int i, j;
            //Check same row if safe
            for (i = 0; i < col; i++)
            {
                if (board[row,i] == 1)
                {
                    return false;
                }
            }

            //Check North-West Diagonal
            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i,j] == 1)
                {
                    return false;
                }
            }

            //Check South-West Diagonal
            for (i = row, j = col; j >= 0 && i < size; i++, j--)
            {
                if (board[i,j] == 1)
                {
                    return false;
                }
            }
            return true;
        }


        Boolean solveNQUtil(int[,] board, int col)
        {
            /* base case: If all queens are placed 
               then return true */
            if (col >= size)
                return true;

            /* Consider this column and try placing 
               this queen in all rows one by one */
            for (int i = 0; i < size; i++)
            {
                /* Check if the queen can be placed on 
                   board[i][col] */
                if (isSafe(board, i, col))
                {
                    /* Place this queen in board[i][col] */
                    board[i,col] = 1;

                    /* recur to place rest of the queens */
                    if (solveNQUtil(board, col + 1) == true)
                        return true;

                    /* If placing queen in board[i][col] 
                       doesn't lead to a solution then 
                       remove queen from board[i][col] */
                    board[i,col] = 0; // BACKTRACK 
                }
            }

            /* If the queen can not be placed in any row in 
               this colum col, then return false */
            return false;
        }

        public void CheckNQueens()
        {
            int[,] board = new int[size,size];
            for(int i = 0 ; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    board[i,j] = 0;
                }
            }

            if (solveNQUtil(board, 0) == false)
            {
                Console.WriteLine("Solution does not exist");
                return;
            }

            PrintSolution(board);
            return;
        }
    }
}
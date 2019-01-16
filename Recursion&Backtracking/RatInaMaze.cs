using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsRecursionNBactracking
{
    //Find the path to the end cell in a maze which has some cells blocked.
    public class RatInaMaze
    {
        private int size = 5;
        void PrintSolution(int[,] maze)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(" " + maze[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }

        //Check if current cell in maze is not blocked
        Boolean isSafe(int[,] maze, int row, int col)
        {
            if(row >=0 && row < size && col >= 0 && col < size && maze[row,col] == 1){
                return true;
            }
            return false;;
        }


        Boolean solveMazeUtil(int[,] maze, int row, int col, int[,] sol)
        {

            if (row == size - 1 && col == size -1){
                sol[row,col] = 1;
                return true;
            }


                if (isSafe(maze, row, col) == true)
                {

                    sol[row,col] = 1;

                    if (solveMazeUtil(maze, row + 1, col, sol) == true)
                        return true;

                    if (solveMazeUtil(maze, row, col + 1, sol ) == true)
                        return true;
                    
                    sol[row,col] = 0; // BACKTRACK 
                    return false;
                }

            return false;
        }

        public void CheckMaze()
        {
            int[,] maze = new int[size,size];
            
            for(int i = 0 ; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    maze[i,j] = 1;
                }
            }

            //Block few cells in maze
            maze[0,1] = 0;
            maze[0,2] = 0; 
            maze[0,3] = 0;
            maze[1,2] = 0;
            maze[2,0] = 0;
            maze[3,1] = 0;
            maze[2,3] = 0;
            maze[3,3] = 0;

           int[,] sol = new int[size,size];
           for(int i = 0 ; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    sol[i,j] = 0;
                }
            }

            PrintSolution(maze);
            Console.WriteLine("");
            if (solveMazeUtil(maze, 0, 0, sol) == false)
            {
                Console.WriteLine("Solution does not exist");
                return;
            }

            PrintSolution(sol);
            return;
        }
    }
}
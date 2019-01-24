using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nsRecursionNBactracking
{
    //Find the path to the end cell in a maze which has some cells blocked.
    public class CrossWordPuzzle
    {
        private int size = 10;
        static void PrintSolution(string[] crossword)
        {
            for (int i = 0; i < crossword.Length; i++)
            {
                Console.WriteLine(crossword[i]);
            }
        }

        static string isAllowed(string[] sol,string[] crosswords, List<string> words, int row, int col)
        {
            //Check For accross
            string s1 = sol[row];
            string word = string.Empty;
            int x = col, y = col;
            while (x >= 0 && s1[x] != '+' && s1[x] != 'X')
            {
                x--;

            }
            while (y <= 9 && s1[y] != '+'  && s1[y] != 'X')
            {
                y++;
            }
            x = x + 1;
            y = y - 1;
            word = s1.Substring(x, y - x + 1);
            Boolean match = false;
            string matchedWord = string.Empty;
            foreach (string w in words)
            {
                if (w.Length == word.Length)
                {
                    Boolean isOK = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != '-' && word[i] != w[i])
                        {
                            isOK = false;
                        }
                    }
                    if (isOK)
                    {
                        match = true;
                        matchedWord = w;
                        break;
                    }
                }
            }
            if (match)
            {
                //We got a matched word. keep track of old state in case we need to backtrack before updating solution
                sol.CopyTo(crosswords,0);
                var aStringBuilder = new StringBuilder(s1);
                aStringBuilder.Remove(x, y - x + 1);
                aStringBuilder.Insert(x, matchedWord);
                sol[row] = aStringBuilder.ToString();
                return matchedWord;
            }


            //Check for Down
            x = row;
            y = row;
            while (x >= 0 && sol[x][col] != '+' && sol[x][col] != 'X')
            {
                x--;

            }
            while (y <= 9 && sol[y][col] != '+' && sol[y][col] != 'X')
            {
                y++;
            }
             x = x + 1;
             y = y - 1;
            word = string.Empty;
            for (int p = x; p <= y; p++)
            {
                word += sol[p][col];
            }

            match = false;
            matchedWord = string.Empty;
            foreach (string w in words)
            {
                if (w.Length == word.Length)
                {
                    Boolean isOK = true;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != '-' && word[i] != w[i])
                        {
                            isOK = false;
                        }
                    }
                    if (isOK)
                    {
                        match = true;
                        matchedWord = w;
                        break;
                    }
                }
            }
            if (match)
            {
                int i=0;
                //We got a matched word. keep track of old state in case we need to backtrack before updating solution
                sol.CopyTo(crosswords,0);
                for (int p = x; p <= y; p++)
                {
                    var aStringBuilder = new StringBuilder(sol[p]);
                    aStringBuilder.Remove(col,1);
                    aStringBuilder.Insert(col, matchedWord[i]);
                    sol[p] = aStringBuilder.ToString();
                    i++;
                }
                return matchedWord;
            }

            return string.Empty;
        }


        static string[] soleCrosswordUntil(string[] crosswords, List<string> words, string[] sol)
        {
            //Check if we have a solution. i.e. there are no '-' character in the solution.
            //Base case.
            Boolean isSolved = true;
            foreach (string str in sol)
            {
                if (str.Contains("-"))
                {
                    isSolved = false;
                    break;
                }
            }

            if (isSolved)
            {
                return sol;
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (sol[i].Contains("-"))
                    {
                        string s1 = isAllowed(sol,crosswords,  words, i, sol[i].IndexOf("-"));
                        if (s1 != string.Empty)
                        {
                            //Remove the first word from List of words to be replaced and add it to the end , so it doesn't get picked first in the next iteration.
                            words.Remove(s1);
                            words.Add(s1);


                            return soleCrosswordUntil(crosswords, words, sol);
       
                        }
                        //Couldn't find a word to fill in the current solution grid.
                        //Backtrack to the previous state of the grid and choose another word.
                        //Also start the loop from the beginning
                        sol = crosswords;
                        i=-1;
                        continue;

                    }
                }
            }
            return sol;
        }

        public static void CheckMaze()
        {
            string[] crosswords = new string[10];
            // crosswords[0] = "++++++++++";
            // crosswords[1] = "+------+++";
            // crosswords[2] = "+++-++++++";
            // crosswords[3] = "+++-++++++";
            // crosswords[4] = "+++-----++";
            // crosswords[5] = "+++-++-+++";
            // crosswords[6] = "++++++-+++";
            // crosswords[7] = "++++++-+++";
            // crosswords[8] = "++++++-+++";
            // crosswords[9] = "++++++++++";
            // crosswords[0] = "+-++++++++";
            // crosswords[1] = "+-++++++++";
            // crosswords[2] = "+-------++";
            // crosswords[3] = "+-++++++++";
            // crosswords[4] = "+-++++++++";
            // crosswords[5] = "+------+++";
            // crosswords[6] = "+-+++-++++";
            // crosswords[7] = "+++++-++++";
            // crosswords[8] = "+++++-++++";
            // crosswords[9] = "++++++++++";
            crosswords[0] = "+-++++++++";
            crosswords[1] = "+-++++++++";
            crosswords[2] = "+-++++++++";
            crosswords[3] = "+-----++++";
            crosswords[4] = "+-+++-++++";
            crosswords[5] = "+-+++-++++";
            crosswords[6] = "+++++-++++";
            crosswords[7] = "++------++";
            crosswords[8] = "+++++-++++";
            crosswords[9] = "+++++-++++";
            // crosswords[0] = "+-++++++++";
            // crosswords[1] = "+-------++";
            // crosswords[2] = "+-++-+++++";
            // crosswords[3] = "+-------++";
            // crosswords[4] = "+-++-++++-";
            // crosswords[5] = "+-++-++++-";
            // crosswords[6] = "+-++------";
            // crosswords[7] = "+++++++++-";
            // crosswords[8] = "++++++++++";
            // crosswords[9] = "++++++++++";
            // crosswords[0] = "+-++++++++";
            // crosswords[1] = "+-++-+++++";
            // crosswords[2] = "+-------++";
            // crosswords[3] = "+-++-++-++";
            // crosswords[4] = "+-++-++-++";
            // crosswords[5] = "+-++-++-++";
            // crosswords[6] = "++++-++-++";
            // crosswords[7] = "+--------+";
            // crosswords[8] = "++++++++++";
            // crosswords[9] = "----------";

            List<string> words = new List<string>();
            string words1 = "DELHI;LONDON;ICELAND;ANKARA";
            //string words1 = "MANIPUR;ANDAMAN;ICELAND;ALLEPY;YANGON;PUNE";
            //string words1 = "ANDAMAN;MANIPUR;ICELAND;ALLEPY;YANGON;PUNE";
            //string words1 = "CALIFORNIA;LASVEGAS;NIGERIA;CANADA;TELAVIV;ALASKA";
            // words.Add("POLAND");
            // words.Add("INDIA");
            // words.Add("LHASA");
            // words.Add("SPAIN");
            // words.Add("NORWAY");
            // words.Add("AGRA");
            // words.Add("ENGLAND");
            // words.Add("GWALIOR");
            words = words1.Split(';').ToList();
            // words.Add(words1.Split(';'));
            // words.Add("DELHI");
            // words.Add("LONDON");
            // words.Add("ICELAND");
            // words.Add("ANKARA");

            string[] sol = (string[])crosswords.Clone();

            //Print input data
            PrintSolution(crosswords);
            Console.WriteLine("");

            sol = soleCrosswordUntil(crosswords, words, sol);

            //Print solution data
            PrintSolution(sol);
            return;
        }
    }
}
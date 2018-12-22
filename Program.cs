using System;
using nsDriverProgram;
using nsStrings;
using nsSorting;
using nsDictionariesnHashmaps;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("ABCD");
            // RemoveCharacters.RemoveCharacters.RemoveCharacterFromString("geeksforgeek", 'g');
            //ReverseString.ReverseString.RemoveCharacterFromString("abcdefg");
            //SpecialPalindrome.SpecialPalindrome.FindSpecialPalindromeCount("nnonnpoo");
            //SpecialPalindrome.SpecialPalindrome.FindSpecialPalindromeCount("aaaa");
            //Solution.whatFlavors(new int[]{2, 2, }, 4);
            // Sorting.BubbleSort(new int[]{5, 8, 12, 10, 4, 6});
            //Sorting.MergeSortDriver(new int[]{5, 8, 10, 4, 6},0,4);
            //MinimumTImeRequired.LCM(new long[]{4, 5, 6}, 12);
            //ReverseSort.ReverseSort.CheckIfReverseSortable(new int[]{5, 6, 12, 11, 15, 15});
            //FraudulentActivityNotification.FraudulentActivityNotification.GetNotification(new int[]{2, 7, 4, 2, 3, 6, 8, 4, 5}, 4);
            //FraudulentActivityNotification.FraudulentActivityNotification.GetNotification(new int[]{2, 3, 4, 2, 3, 6, 8, 4, 5}, 5);
            //MinimumAbsoluteDifference.MinimumAbsoluteDifference.GetminimumDifference(new int[] {-59, -36, -13, 1, -53, -92, -2, -96, -54, 75});
            //GreedyFlorist.GreedyFlorist.MInimizeCost(3, new int[] {2, 5, 6});
            //MaxMin.MaxMin.MinimumUnfairness(3, new int[] {100, 200, 300, 350, 400, 401, 402});
            //BalancedBrackets.BalancedBrackets.IsBalanced("()()()[]");
            //Stack.Stack.ImplementStack();
            //ATaleOfTwoStacks.ATaleOfTwoStacks.DriverMethod();
            //CastleOnTheGrid.CastleOnTheGrid.MinimumMoves(new string[]{".X.",".X.","..."},0, 0, 0, 2);
            //TripleSum.TripleSum.NumberOfTriplets(new int[]{1, 3, 5, 7}, new int[]{}, new int[]{});
            DriverProgram program= new DriverProgram();
            // program.PerformActionsSingleLinkedList(); 
            //program.PerformActionsDoubleLinkedList();
            //nsSockMerchant.SockMerchant.GetPairs(10, new int[]{1, 1, 3, 1, 2, 1, 3, 3, 3, 3});
            //nsSockMerchant.CountingValleys.GetNumberOfValleys(8, "UDDDUDUU");
            //nsSockMerchant.RepeatedString.GetNumberOfA("jdiacikk",899491);
            //nsStacksQueues.EvaluatePostFixExpression.getPostfixExpression("512+4*+3-");
            //nsStacksQueues.EqualStacks.minimumEqualStack(new int[]{3, 2, 1, 1, 1}, new int[]{4, 3, 2}, new int[]{1, 1, 4, 1});
            // nsStacksQueues.GameOfTwoStacks.MaxScore(12, new int[]{1, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 1, 1, 1, 0, 0},
            //  new int[]{0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 1, 0, 1});
            //nsStacksQueues.MaximumElement.GetMaxElement();
            //SuperReducedString.GetSuperReducedString("baab");
            //MinSwaps.GetMinimumSwaps(new int[]{3, 4, 2, 5, 1});
            //CountTriplets.NumberOfTriplets(new System.Collections.Generic.List<long>{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,},1);
            //FrequencyQueries.CreateInput();
            program.PerformActionsCircularLinkedList();
        }
    }
}

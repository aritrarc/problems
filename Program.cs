using System;

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
            Sorting.MergeSortDriver(new int[]{5, 8, 10, 4, 6},0,4);
            //MinimumTImeRequired.LCM(new long[]{4, 5, 6}, 12);
        }
    }
}

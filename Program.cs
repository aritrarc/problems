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
            //Sorting.BubbleSort(new int[]{5, 8, 12, 10, 4, 6});
            Solution.BinarySearch(new int[]{7, 2, 5, 4, 11}, 12);
        }
    }
}

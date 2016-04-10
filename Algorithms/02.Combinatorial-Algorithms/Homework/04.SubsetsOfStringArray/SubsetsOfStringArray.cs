namespace _04.SubsetsOfStringArray
{
    using System;
    using System.Linq;

    public class SubsetsOfStringArray
    {
        private static int k;
        private static string[] s;

        public static void Main()
        {
            s = new[] { "test", "rock", "fun" };
            k = 2;

            int[] arr = new int[k];

            GenerateCombinationsNoRepetition(arr);
        }

        private static void GenerateCombinationsNoRepetition(int[] arr, int index = 0, int start = 0)
        {
            if (index >= k)
            {
                PrintCombinations(arr);
                return;
            }

            for (int i = start; i < s.Length; i++)
            {
                arr[index] = i;
                GenerateCombinationsNoRepetition(arr, index + 1, i + 1);
            }
        }

        private static void PrintCombinations(int[] array)
        {
            Console.WriteLine("({0})", string.Join(" ", array.Select(i => s[i])));
        }
    }
}
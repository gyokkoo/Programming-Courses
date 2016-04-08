namespace _05.CombinationsWithoutRepetition
{
    using System;

    public class CombinationsWithoutRepetition
    {
        public static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            var arr = new int[k];
            GenerateCombinations(arr, n);
        }

        private static void GenerateCombinations(int[] arr, int n, int startNum = 1, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = startNum; i <= n; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, n, i + 1, index + 1);
                }
            }
        }
    }
}

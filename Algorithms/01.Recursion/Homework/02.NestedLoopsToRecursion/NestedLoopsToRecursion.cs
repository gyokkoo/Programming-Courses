namespace _02.NestedLoopsToRecursion
{
    using System;

    public class NestedLoopsToRecursion
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            GenerateCombinations(arr);
        }

        private static void GenerateCombinations(int[] arr, int index = 0)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1);
                }
            }
        }
    }
}
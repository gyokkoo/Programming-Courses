namespace _02.SelectionSort
{
    using System;
    using System.Linq;

    public class SelectionSort
    {
        private static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                SwapTwoElementsInArray(numbers, i, minIndex);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void SwapTwoElementsInArray(int[] numbers, int i, int j)
        {
            int swapNumber = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = swapNumber;
        }
    }
}
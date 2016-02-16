namespace _1.BubbleSort
{
    using System;
    using System.Linq;

    public class BubbleSort
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        SwapElementsInArray(j, j + 1, numbers);
                    }
                }
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void SwapElementsInArray(int i, int j, int[] numbers)
        {
            int exchangeValue = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = exchangeValue;
        }
    }
}